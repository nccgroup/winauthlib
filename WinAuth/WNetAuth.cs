using System;
using System.Runtime.InteropServices;

namespace WinAuth
{

    /* ########################################################################################
     *                  Base Class To Provide SMB Auth / Drive Mapping Functionality
     *                  
     *                       Author: Chris Thomas, chris dot thomas at nccgroup dot com
     * ########################################################################################
     * 
     * TODO:
     *  1. Valid IP Checking
     *  2. Valud UNC Path Checking
     *  3. More SMB_CODE Entries
     * 
     * 
     * Version 1.2 (1st July 2013)
     *  *Released On NCC Git Hub*
     *  Fixed: Code Clean-Up
     *  
     * Version 1.1 (7th Jan 2013)
     * + Added Enums for Connection Options
     * + Added: Drive is automatically unmapped upon auth to remove any chached creds
     * 
     * Version 1.0 (8th June 2012)
     * + Initial Release
     * 
     * 
     *      Released as open source by NCC Group Plc - http://www.nccgroup.com/
     *
     *      Developed by Chris Thomas, chris dot thomas at nccgroup dot com
     *
     *      https://github.com/nccgroup/winauthlib
     *
     *      Released under AGPL see LICENSE for more information
     */

    public class WNetAuth
    {
        #region API

                //http://msdn.microsoft.com/en-us/library/windows/desktop/aa385413(v=vs.85).aspx
                //http://www.pinvoke.net/default.aspx/mpr.wnetaddconnection2
                [DllImport("mpr.dll")]
                private static extern int WNetAddConnection2A(ref NETRESOURCE lpNetResource, String lpPassword, String lpUsername, UInt32 dwFlags);

                
                //http://msdn.microsoft.com/en-us/library/windows/desktop/aa385427(v=vs.85).aspx
                //http://www.pinvoke.net/default.aspx/mpr/WNetCancelConnection2.html
                [DllImport("mpr.dll")]
                private static extern int WNetCancelConnection2A(String lpName, UInt32 dwFlags, Int32 fForce);


                //http://msdn.microsoft.com/en-us/library/windows/desktop/aa385353(v=vs.85).aspx
                [StructLayout(LayoutKind.Sequential)]
                private struct NETRESOURCE
                {
                    public RESOURCE_SCOPE dwScope;
                    public RESOURCE_TYPE dwType;
                    public RESOURCE_DISPLAYTYPE dwDisplayType;
                    public RESOURCE_USAGE dwUsage;
                    public String lpLocalName;
                    public String lpRemoteName;
                    public String lpComment;
                    public String lpProvider;
                }

                private const Int32 RESOURCETYPE_DISK = 0x1;
                private const Int32 CONNECT_TEMPORARY = 0x00000004;
                private const Int32 CONNECT_INTERACTIVE = 0x00000008;
                private const Int32 CONNECT_PROMPT = 0x00000010;

                //http://msdn.microsoft.com/en-us/library/windows/desktop/aa385353(v=vs.85).aspx
                public enum RESOURCE_DISPLAYTYPE
                {
                    RESOURCEDISPLAYTYPE_GENERIC = 0,
                    RESOURCEDISPLAYTYPE_DOMAIN = 1,
                    RESOURCEDISPLAYTYPE_SERVER = 2,
                    RESOURCEDISPLAYTYPE_SHARE = 3,
                    RESOURCEDISPLAYTYPE_FILE = 4,
                    RESOURCEDISPLAYTYPE_GROUP = 5,
                    RESOURCEDISPLAYTYPE_NETWORK = 6,
                    RESOURCEDISPLAYTYPE_ROOT = 7,
                    RESOURCEDISPLAYTYPE_SHAREADMIN = 8,
                    RESOURCEDISPLAYTYPE_DIRECTORY = 9,
                    RESOURCEDISPLAYTYPE_TREE = 10,
                    RESOURCEDISPLAYTYPE_NDSCONTAINER = 11
                }

                public enum RESOURCE_SCOPE
                {
                    RESOURCE_CONNECTED = 1,
                    RESOURCE_GLOBALNET = 2,
                    RESOURCE_REMEMBERED = 3,
                    RESOURCE_RECENT = 4,
                    RESOURCE_CONTEXT = 5
                }

                public enum RESOURCE_TYPE
                {
                    RESOURCETYPE_ANY = 0,
                    RESOURCETYPE_DISK = 1,
                    RESOURCETYPE_PRINT = 2,
                    RESOURCETYPE_RESERVED = 8,
                }

                public enum RESOURCE_USAGE
                {
                    RESOURCEUSAGE_CONNECTABLE = 1,
                    RESOURCEUSAGE_CONTAINER = 2,
                    RESOURCEUSAGE_NOLOCALDEVICE = 4,
                    RESOURCEUSAGE_SIBLING = 8,
                    RESOURCEUSAGE_ATTACHED = 16,
                    RESOURCEUSAGE_ALL = (RESOURCEUSAGE_CONNECTABLE | RESOURCEUSAGE_CONTAINER | RESOURCEUSAGE_ATTACHED),
                }
        #endregion

        public enum SMB_RESULT_CODE
        {
            UNKNOWN = -1,
            /// <summary>
            /// Successfull Authentication
            /// </summary>
            AUTH_SUCCESS = 0,
            /// <summary>
            /// Error: Network Path Not Found
            /// </summary>
            NET_PATH_NOT_FOUND = 53,
            /// <summary>
            /// Error: Cached Creds Already Present
            /// </summary>
            CACHED_CREDS_PRESENT = 1219,
            /// <summary>
            /// Error: Account Is Not Permitted To Logon
            /// </summary>
            ACCOUNT_NOT_PERMITTED_TO_LOGIN = 1244,
            /// <summary>
            /// Error: Bad Username Or Password
            /// </summary>
            BAD_USERNAME_PASSWORD = 1326,
        }


        /// <summary>
        /// Maps A Network Drive
        /// </summary>
        /// <param name="domain">Domain To Be Used(Can be Blank)</param>
        /// <param name="username">Connect As This User</param>
        /// <param name="password">Users Password</param>
        /// <param name="host">Target Host</param>
        /// <returns>Standard SMB Result Code</returns>
        public SMB_RESULT_CODE MapIPCDrive(String domain, String username, String password, String host)
        {
            NETRESOURCE structNetResource = new NETRESOURCE();

            //create struct data          
            structNetResource.dwScope = RESOURCE_SCOPE.RESOURCE_GLOBALNET;
            structNetResource.dwType = RESOURCE_TYPE.RESOURCETYPE_ANY;
            structNetResource.dwDisplayType = RESOURCE_DISPLAYTYPE.RESOURCEDISPLAYTYPE_GENERIC;
            structNetResource.dwUsage = RESOURCE_USAGE.RESOURCEUSAGE_ALL;

            //we are mapping the IPC drive.
            structNetResource.lpRemoteName = @"\\" + host + @"\IPC$";
            structNetResource.lpLocalName = String.Empty;
            
            //has the user supplied a domain?
            if (domain != String.Empty) { username = domain + "\\" + username; }          

            try
            {
                //remove any cached creds that are already present.
                this.UnMapDrive(host, "IPC$");
            }
            catch
            {
                //left empty due to trying to unmap a non-mapped drive will cause an exception
            }//end of try-catch

            try
            {
                Int32 _ReturnValue = WNetAddConnection2A(ref structNetResource, password, username, CONNECT_INTERACTIVE);

                return (SMB_RESULT_CODE)_ReturnValue;
            }
            catch (Exception)
            {
                return SMB_RESULT_CODE.UNKNOWN;
            }//end of try-catch

        }//end of method MapIPCDrive


        /// <summary>
        /// Unmaps Network Drive
        /// </summary>
        /// <param name="host">Target Host</param>
        /// <param name="share">Target Share</param>
        /// <returns>Standard Windows System Error Code</returns>
        public Int32 UnMapDrive(String host, String share)
        {
            try
            {
                //attempt to unmap the drive
                return WNetCancelConnection2A(@"\\" + host + @"\" + share, 0, 0);
            }
            catch
            {
                return -1;
            }//end of try-catch
        }//end of method UnMapDrive


        public String GetSMBResultCode(Int32 code)
        {
            switch (code)
            {
                case 0: return "Authentication Successfull!";
                case 53: return "Authentication Failed. Reason: \"Network Path Not Found\"";
                case 1219: return "Authentication Failed. Reason: \"Cached Creds Already Present\"";
                case 1244: return "Authentication Failed. Reason: \"Account Not Permitted To Login\"";
                case 1326: return "Authentication Failed. Reason: \"Bad Username or Password\"";
                default: return "Authentication Failed. Unknown Code [" + code + "]";
            }//end of switch
        }//end of method GetSMBResultCode

    }//end of class WNetAuth
}
