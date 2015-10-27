using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eForm.Win.Enum
{
    public enum FpReturn
    {
        Success = 0,
        ErrorOpenReader,
        ErrorSelectDevice,
        ErrorCardDetect,
        ErrorCardConnectA,
        SelectPTS,
        ErrorSelJPNApp,
        ErrorJPN_GMPCName,
        ErrorJPN_IDNum,
        ErrorJPN_Address1,
        ErrorJPN_Address2,
        ErrorJPN_Address3,
        ErrorJPN_Postcode,
        ErrorJPN_City,
        ErrorJPN_State,
        ErrorJPN_Citizenship,
        ErrorJPN_Religion,
        ErrorJPN_EastMsian,
        ErrorJPN_Gender,
        ErrorJPN_Thumb1,
        ErrorJPN_Thumb2,
        ErrorSaveTemplateFile,
        ErrorUnknown,
        ErrorSCardEstablishContext,
        ErrorSCardListReaders,
        ErrorSaveInfoFile,
        ErrorConnect,
        ErrorSetDialog,
        ErrorSetProperty,
        ErrorVerify,

    }
}
