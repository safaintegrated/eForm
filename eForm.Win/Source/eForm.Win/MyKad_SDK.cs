using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace eForm.Win
{
    public class MyKad_SDK
    {
        [DllImport("gsdkpcsc.dll", EntryPoint = "_OpenReader@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int OpenReader();

        [DllImport("gsdkpcsc.dll", EntryPoint = "_SelectDevice@8", CallingConvention = CallingConvention.StdCall)]
        public static extern int SelectDevice(string readerName, int readerNameLen);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_CardConnectA@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int CardConnectA();

        [DllImport("gsdkpcsc.dll", EntryPoint = "_CardDisconnect@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int CardDisconnect();

        [DllImport("gsdkpcsc.dll", EntryPoint = "_CloseReader@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int CloseReader();

        [DllImport("gsdkpcsc.dll", EntryPoint = "_GetError@0", CallingConvention = CallingConvention.StdCall)]
        public static extern short GetError();

        [DllImport("gsdkpcsc.dll", EntryPoint = "_SelectPTS@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int SelectPTS(int speedIndex);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_CardDetect@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int CardDetect(ref int state);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_SelJPNApp@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int SelJPNApp();

        [DllImport("gsdkpcsc.dll", EntryPoint = "_SelIMMApp@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int SelIMMApp();

        [DllImport("gsdkpcsc.dll", EntryPoint = "_SelJPJApp@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int SelJPJApp();

        //JPN	
        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Address1@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Address1(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Address2@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Address2(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Address3@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Address3(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Citizenship@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Citizenship(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_City@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_City(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_GMPCName@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_GMPCName(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Gender@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Gender(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Religion@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Religion(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_EastMsian@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_EastMsian(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_IDNum@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_IDNum(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Photo@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Photo(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Postcode@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_Postcode(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_State@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPN_State(byte[] data);
        //Mesp
        [DllImport("gsdkpcsc.dll", EntryPoint = "_Proton_Balance@8", CallingConvention = CallingConvention.StdCall)]
        public static extern int Proton_Balance(ref double balance, ref int cur);
        //JPJ
        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPJ_LicenseType@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPJ_LicenseType(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPJ_VehicleClass@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPJ_VehicleClass(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPJ_ValidityPeriod@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int JPJ_ValidityPeriod(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Thumb1@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int _JPN_Thumb1(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_JPN_Thumb2@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int _JPN_Thumb2(byte[] data);


        //IMM
        [DllImport("gsdkpcsc.dll", EntryPoint = "_IMM_PMAPassportNum@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMM_PMAPassportNum(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_IMM_PMADocType@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMM_PMADocType(byte[] data);

        [DllImport("gsdkpcsc.dll", EntryPoint = "_IMM_PMAExpiryDate@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int IMM_PMAExpiryDate(byte[] data);

        //		[DllImport("gsdkpcsc.dll", EntryPoint="", CallingConvention=CallingConvention.StdCall)]

        //	Winscard.dll
        // PC/SC(Personal Computer/Smart Card) API WinScard.dll

        public struct SCARD_IO_REQUEST
        {
            public int dwProtocol;
            public int cbPciLength;
        }


        [DllImport("WinScard.dll")]
        public static extern int SCardEstablishContext(uint dwScope,
        int nNotUsed1, int nNotUsed2, ref int phContext);

        [DllImport("WinScard.dll")]
        public static extern int SCardReleaseContext(int phContext);

        [DllImport("WinScard.dll")]
        public static extern int SCardConnect(int hContext, string cReaderName,
        uint dwShareMode, uint dwPrefProtocol, ref int phCard, ref int ActiveProtocol);

        [DllImport("WinScard.dll")]
        public static extern int SCardDisconnect(int hCard, int Disposition);


        [DllImport("winscard.dll")]
        public static extern int SCardListReaders(int hContext,
            string mszGroups,
            byte[] mszReaders, //<- Here is the difference.
        out uint pcchReaders);

        [DllImport("WinScard.dll")]
        public static extern int SCardTransmit(int hCard,
        ref SCARD_IO_REQUEST pioSendPci, byte[] pbSendBuffer, int cbSendLength,
        ref SCARD_IO_REQUEST pioRecvPci, ref byte pbRecvBuffer, ref int pcbRecvLength);


        public struct CBM_DlgItem
        {
            public IntPtr hAsyncMsg;
            public IntPtr hStatusMsg;
            public IntPtr hViewer;
        }

        public struct CBM_Property
        {
            public bool bViewer;
            public int iTemplateType;
        }

        public struct CBM_RdrName
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public char[] cRdrName;
            public Int32 iNbrRdr;
        }

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_EnumerateReader@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_Enumerate([Out, MarshalAs(UnmanagedType.LPArray)] CBM_RdrName[] dlgRdr);

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_OpenReader@8", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_OpenReader(int iPortNo, byte[] bRdrName);

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_CloseReader@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_CloseReader();

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_Close@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_Close();

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_Init@0", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_Init();

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_SetDialog@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_SetDialog(ref CBM_DlgItem dlgItem);

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_SetProperty@4", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_SetProperty(ref CBM_Property dlgProp);

        [DllImport("MorphoCBM.dll", EntryPoint = "_CBM_MorphoVerify@16", CallingConvention = CallingConvention.StdCall)]
        public static extern int CBM_MorphoVerify(byte[] pLThumbBuffer, Int32 dwLThumbBufferLen, byte[] pRThumbBuffer, Int32 dwRThumbBufferLen);

    }
}
