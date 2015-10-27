namespace eForm.Data.Device
{
    public class Device: BaseEntity
    {

        public int MachineId { get; set; }

        public virtual Machine Machine { get; set; }


        public ReaderType ReaderType { get; set; }

        public string SerialNo { get; set; }
        
    }
}
