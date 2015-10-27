using eForm.Data;
using eForm.Win.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace eForm.Win.Services
{
    public class MyKadService
    {
        private string _workDirectory;
        private string _thumbPath1 = "gmpcad1.bin";
        private string _thumbPath2 = "gmpcad2.bin";
        private string _infoPath = "info.txt";
        private string _verifyStatus = "verify.txt";

        private List<string> _rdrList = new List<string>();
        private string _previousWorkingReader;

        public MyKadService()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilePath = Path.Combine(localAppData, "eForm");

            if (!Directory.Exists(userFilePath))
                Directory.CreateDirectory(userFilePath);

            _workDirectory = userFilePath;
        }


        public string[] RefreshReaderList()
        {
            int ContextHandle = 0;
            uint readerCount = 0;
            byte[] pbyReaderNames = new byte[152];
            StringBuilder readerList = new StringBuilder();

            int status = MyKad_SDK.SCardEstablishContext(0, 0, 0, ref ContextHandle);
            if (status != 0)
                return null;

            status = MyKad_SDK.SCardListReaders(ContextHandle, null, pbyReaderNames, out readerCount);
            if (status != 0)
                return null;

            byte[] rdr = new byte[readerCount];
            status = MyKad_SDK.SCardListReaders(ContextHandle, null, rdr, out readerCount);
            if (status != 0)
                return null;
            string strRdrName = null;
            for (int i = 0; i < readerCount; i++)
            {
                strRdrName += Convert.ToChar(rdr[i]);
            }

            string[] rdrs = strRdrName.Split('\0');
            _rdrList = new List<string>();
            for (int i = 0; i < rdrs.Count(); i++)
            {
                if (!string.IsNullOrEmpty(rdrs[i]))
                {
                    _rdrList.Add(rdrs[i]);
                }
            }
            return _rdrList.ToArray();

        }

        public Data.ProfileInfo ReadFromMyKad()
        {
            ProfileInfo pf = null;
            Image img = null;
            try
            {
                List<string> sList = new List<string>();
                byte[] fp1 = null;
                byte[] fp2 = null;

                RefreshReaderList();

                FpReturn state = FpReturn.ErrorUnknown;
                //Read mykad using previous working reader
                state = ReadMyKad(_previousWorkingReader, out sList, out fp1, out fp2, out img);

                //If failed, try all the readers
                if (state != FpReturn.Success)
                {
                    foreach (var rdr in _rdrList)
                    {
                        state = ReadMyKad(rdr, out sList, out fp1, out fp2, out img);
                        if (state == FpReturn.Success)
                        {
                            _previousWorkingReader = rdr;
                            break;
                        }
                    }
                }

                if (state != FpReturn.Success)
                    throw new Exception("Failed to read MyKad");

                pf = new ProfileInfo();
                //_photoImage = img;
                foreach (string s in sList)
                {
                    if (s.StartsWith("JPN_IDNum"))
                    {
                        string[] ids = s.Split('=');
                        pf.IcNo = ids[1];
                    }
                    else if (s.StartsWith("JPN_GMPCName"))
                    {
                        string[] ids = s.Split('=');
                        pf.FullName = ids[1];
                    }
                    else if (s.StartsWith("JPN_Citizenship"))
                    {
                        string[] ids = s.Split('=');
                        pf.Citizenship = ids[1];
                    }
                    else if (s.StartsWith("JPN_Gender"))
                    {
                        string[] ids = s.Split('=');
                        pf.Gender = ids[1];
                    }
                    else if (s.StartsWith("JPN_Address1"))
                    {
                        string[] ids = s.Split('=');
                        pf.Address1 = ids[1];
                    }
                    else if (s.StartsWith("JPN_Address2"))
                    {
                        string[] ids = s.Split('=');
                        pf.Address2 = ids[1];
                    }
                    else if (s.StartsWith("JPN_Address3"))
                    {
                        string[] ids = s.Split('=');
                        pf.Address3 = ids[1];
                    }
                    else if (s.StartsWith("JPN_Postcode"))
                    {
                        string[] ids = s.Split('=');
                        pf.Postcode = ids[1];
                    }
                    else if (s.StartsWith("JPN_City"))
                    {
                        string[] ids = s.Split('=');
                        pf.City = ids[1];
                    }
                    else if (s.StartsWith("JPN_State"))
                    {
                        string[] ids = s.Split('=');
                        pf.State = ids[1];
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            //ProfileInfo = new ProfileInfo
            //{
            //    FullName = "Fakhrul Azran Bin Nawi",
            //    IcNo = "99999999-99-9999",
            //    //DateOfBirth = new DateTime(1975, 01, 01),
            //    Gender = "Male"
            //};

            return pf;
        }


        private Data.ProfileInfo ReadFromMyKad(string reader, out Image photoImage)
        {
            ProfileInfo pf = null;
            photoImage = null;
            try
            {
                List<string> sList = new List<string>();
                byte[] fp1 = null;
                byte[] fp2 = null;
                Image img = null;
                var state = ReadMyKad(reader, out sList, out fp1, out fp2, out img);

                if (state != FpReturn.Success)
                    throw new Exception("Failed to read MyKad");

                pf = new ProfileInfo();
                photoImage = img;
                foreach (string s in sList)
                {
                    if (s.StartsWith("JPN_IDNum"))
                    {
                        string[] ids = s.Split('=');
                        pf.IcNo = ids[1];
                    }
                    else if (s.StartsWith("JPN_GMPCName"))
                    {
                        string[] ids = s.Split('=');
                        pf.FullName = ids[1];
                    }
                    else if (s.StartsWith("JPN_Citizenship"))
                    {
                        string[] ids = s.Split('=');
                        pf.Citizenship = ids[1];
                    }
                    else if (s.StartsWith("JPN_Gender"))
                    {
                        string[] ids = s.Split('=');
                        pf.Gender = ids[1];
                    }
                    else if (s.StartsWith("JPN_Address1"))
                    {
                        string[] ids = s.Split('=');
                        pf.Address1 = ids[1];
                    }
                    else if (s.StartsWith("JPN_Address2"))
                    {
                        string[] ids = s.Split('=');
                        pf.Address2 = ids[1];
                    }
                    else if (s.StartsWith("JPN_Address3"))
                    {
                        string[] ids = s.Split('=');
                        pf.Address3 = ids[1];
                    }
                    else if (s.StartsWith("JPN_Postcode"))
                    {
                        string[] ids = s.Split('=');
                        pf.Postcode = ids[1];
                    }
                    else if (s.StartsWith("JPN_City"))
                    {
                        string[] ids = s.Split('=');
                        pf.City = ids[1];
                    }
                    else if (s.StartsWith("JPN_State"))
                    {
                        string[] ids = s.Split('=');
                        pf.State = ids[1];
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            //ProfileInfo = new ProfileInfo
            //{
            //    FullName = "Fakhrul Azran Bin Nawi",
            //    IcNo = "99999999-99-9999",
            //    //DateOfBirth = new DateTime(1975, 01, 01),
            //    Gender = "Male"
            //};

            return pf;
        }

        private void DisconnectSmartCard()
        {
            try
            {
                MyKad_SDK.CardDisconnect();
                MyKad_SDK.CloseReader();
            }
            catch
            {
            }

        }
        public FpReturn ReadMyKad(string reader, out List<string> strList, out byte[] fp1, out byte[] fp2, out Image img)
        {
            FpReturn r = FpReturn.ErrorUnknown;
            strList = new List<string>();
            fp1 = null;
            fp2 = null;
            img = null;
            try
            {
                r = ConnectSmartCard(reader);
                if (r != FpReturn.Success)
                    throw new Exception();
                r = ReadJPN(out strList, out fp1, out fp2, out img);
                if (r != FpReturn.Success)
                    throw new Exception();

            }
            catch
            {
            }
            finally
            {
                DisconnectSmartCard();
            }

            return r;
        }

        private string ConvertByteToString(byte[] data)
        {
            System.Text.StringBuilder val = new System.Text.StringBuilder(null);
            char[] arr = System.Text.Encoding.ASCII.GetChars(data);
            val.Append(arr);
            return val.ToString();
        }

        private void ResetByteArray(ref byte[] arr)
        {
            for (long i = 0; i < arr.LongLength; ++i)
            {
                arr[i] = 0x00;
            }
        }

        private FpReturn ReadJPN(out List<string> strList, out byte[] fp1, out byte[] fp2, out Image img)
        {
            //string APIname = "";
            int status = 0;
            int state = 88;
            byte[] temp = new byte[80];
            strList = new List<string>();
            //sb = new StringBuilder();
            ////ClearScreen();
            //Application.DoEvents();
            fp1 = null;
            fp2 = null;
            img = null;

            try
            {
                //btnReadMyKad.Enabled = false;

                status = MyKad_SDK.SelJPNApp();
                if (status != 0)
                    return FpReturn.ErrorSelJPNApp;

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_GMPCName(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_GMPCName;
                strList.Add(string.Format("{0}={1}", "JPN_GMPCName", ConvertByteToString(temp).Trim()));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_IDNum(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_IDNum;
                strList.Add(string.Format("{0}={1}", "JPN_IDNum", ConvertByteToString(temp).TrimEnd('\0')));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_Address1(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_Address1;
                strList.Add(string.Format("{0}={1}", "JPN_Address1", ConvertByteToString(temp)).TrimEnd('\0'));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_Address2(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_Address2;
                strList.Add(string.Format("{0}={1}", "JPN_Address2", ConvertByteToString(temp)).TrimEnd('\0'));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_Address3(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_Address3;
                strList.Add(string.Format("{0}={1}", "JPN_Address3", ConvertByteToString(temp).TrimEnd('\0')));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_Postcode(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_Postcode;

                string postcode = string.Empty;
                int i = 0;
                foreach (byte single in temp)
                {
                    postcode += single.ToString("X2");
                    if (2 == i++)
                    {
                        break;
                    }
                }
                postcode = postcode.Substring(0, 5);
                strList.Add(string.Format("{0}={1}", "JPN_Postcode", postcode));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_City(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_City;
                strList.Add(string.Format("{0}={1}", "JPN_City", ConvertByteToString(temp).TrimEnd('\0')));

                status = MyKad_SDK.JPN_State(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_State;
                strList.Add(string.Format("{0}={1}", "JPN_State", ConvertByteToString(temp).TrimEnd('\0')));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_Citizenship(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_Citizenship;
                strList.Add(string.Format("{0}={1}", "JPN_Citizenship", ConvertByteToString(temp).TrimEnd('\0')));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_Religion(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_Religion;
                strList.Add(string.Format("{0}={1}", "JPN_Religion", ConvertByteToString(temp).TrimEnd('\0')));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_EastMsian(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_EastMsian;
                strList.Add(string.Format("{0}={1}", "JPN_EastMsian", ConvertByteToString(temp).TrimEnd('\0')));

                ResetByteArray(ref temp);
                status = MyKad_SDK.JPN_Gender(temp);
                if (status != 0)
                    return FpReturn.ErrorJPN_Gender;
                strList.Add(string.Format("{0}={1}", "JPN_Gender", ConvertByteToString(temp).TrimEnd('\0')));

                if (!SaveInfoFile(strList, _infoPath))
                    return FpReturn.ErrorSaveInfoFile;

                byte[] photo = new byte[4000];
                status = MyKad_SDK.JPN_Photo(photo);
                if (0 == status)
                {
                    MemoryStream memstr = new MemoryStream(photo);
                    img = new Bitmap(memstr);
                    //pictureBoxPhoto.Image = new Bitmap(memstr);
                }

                //if (0 == status)
                //{
                fp1 = new byte[598];
                status = MyKad_SDK._JPN_Thumb1(fp1);
                if (status != 0)
                    return FpReturn.ErrorJPN_Thumb1;

                if (!SaveTemplateFile(fp1, fp1.Length, _thumbPath1))
                    return FpReturn.ErrorSaveTemplateFile;

                //if (0 == status)
                //{
                fp2 = new byte[598];
                status = MyKad_SDK._JPN_Thumb2(fp2);
                if (status != 0)
                    return FpReturn.ErrorJPN_Thumb2;

                if (!SaveTemplateFile(fp2, fp2.Length, _thumbPath2))
                    return FpReturn.ErrorSaveTemplateFile;
                //    APIname = "JPN_Thumb2";
                //    if (0 == status)
                //    {
                //        //Thumb 2 template will store in thumb2 byte array
                //        //Normally Thumb 2 is left thumb
                //    }
                //}
                return FpReturn.Success;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(null, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                //if (0 != status)
                //    ErrorHandle(APIname, status, state);

                //btnReadMyKad.Enabled = true;
            }

            return FpReturn.ErrorUnknown;

        }

        private bool SaveInfoFile(List<string> strList, string _infoPath)
        {
            bool r = false;
            try
            {
                if (!Directory.Exists(_workDirectory))
                {
                    Directory.CreateDirectory(_workDirectory);
                }

                using (StreamWriter sw = new StreamWriter(Path.Combine(_workDirectory, _infoPath), false))
                {
                    foreach (string s in strList)
                        sw.WriteLine(s);
                }
                r = true;
            }
            catch (Exception)
            {

            }
            return r;
        }

        private bool SaveTemplateFile(byte[] BytesToSave, int NoOfBytes, string FilePath)
        {
            bool r = false;
            try
            {
                if (!Directory.Exists(_workDirectory))
                {
                    Directory.CreateDirectory(_workDirectory);
                }
                FileStream fptr = new FileStream(Path.Combine(_workDirectory, FilePath), FileMode.Create, FileAccess.Write);
                if (NoOfBytes > 0)
                {
                    using (BinaryWriter bw = new BinaryWriter(fptr))
                    {
                        bw.Write(BytesToSave, 0, 512);
                    }
                }
                fptr.Close();
                r = true;
            }
            catch (Exception ex)
            {

            }
            return r;
        }

        private FpReturn ConnectSmartCard(string reader)
        {
            int status = 0;
            int state = 0;
            int ContextHandle = 0;
            uint readerCount = 0;
            byte[] pbyReaderNames = new byte[152];
            StringBuilder readerList = new StringBuilder();

            status = MyKad_SDK.SCardEstablishContext(0, 0, 0, ref ContextHandle);
            if (status != 0)
                return FpReturn.ErrorSCardEstablishContext;

            //status = MyKad_SDK.SCardListReaders(ContextHandle, null, pbyReaderNames, out readerCount);
            //if (status != 0)
            //    return FpReturn.ErrorSCardListReaders;


            //byte[] rdr = new byte[readerCount];
            //status = MyKad_SDK.SCardListReaders(ContextHandle, null, rdr, out readerCount);
            //if (status != 0)
            //    return FpReturn.ErrorSCardListReaders;
            //string strRdrName = null;
            //for (int i = 0; i < readerCount; i++)
            //{
            //    strRdrName += Convert.ToChar(rdr[i]);

            //}

            //string[] RdrName = strRdrName.Split('\0');


            MyKad_SDK.CBM_RdrName[] dlgRdr = new MyKad_SDK.CBM_RdrName[100];
            MyKad_SDK.CBM_Init();
            status = MyKad_SDK.CBM_Enumerate(dlgRdr);

            MyKad_SDK.CloseReader();

            status = MyKad_SDK.OpenReader();
            if (status != 0)
                return FpReturn.ErrorOpenReader;

            //string reader = IniFile.IniReadValue("device.ini", "Reader", "Name", @"IRIS BCR200DTP 11111001130700207 CT01 2");
            //string reader = comboBox1.Text;
            status = MyKad_SDK.SelectDevice(reader, reader.Length);
            if (status != 0)
                return FpReturn.ErrorSelectDevice;

            status = MyKad_SDK.CardDetect(ref state);
            if (status != 0)
                return FpReturn.ErrorCardDetect;

            status = MyKad_SDK.CardConnectA();
            if (status != 0)
                return FpReturn.ErrorCardConnectA;

            status = MyKad_SDK.SelectPTS(0x13/*38400bps*/);
            if (status != 0)
                return FpReturn.SelectPTS;

            return FpReturn.Success;
        }


        public string GetThumb1Path()
        {
            return Path.Combine(_workDirectory, _thumbPath1);
        }

        public string GetThumb2Path()
        {
            return Path.Combine(_workDirectory, _thumbPath2);
        }

        public string GetWorkDirectory()
        {
            return _workDirectory;

        }

        public string GetVerifyStatus()
        {
            return _verifyStatus;
        }
    }
}
