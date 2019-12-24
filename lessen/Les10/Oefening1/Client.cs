namespace Clients
{
    public class Client
    {
        /// <summary>
        /// Class for the creation of a client.
        /// </summary>
        
        // Fields
        private string name;

        //private ContactPerson cp;
        private  List<ContactPerson> contactPersons;
        private string vat;
        //private Address companyAddress;

        private  List<Adress> companyAdress;
        private string remarks;
        private ClientType type;

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public List<ContactPerson> contactPersons
        {
            get
            {
                return this.contactPersons;
            }
            set
            {
                this.contactPersons = value;
            }
        }
        public string Vat
        {
            get
            {
                return this.vat;
            }
            set
            {
                this.vat = value;
            }
        }
        
        public List<Adress> CompanyAdress
        {
            get
            {
                return this.companyAdress;
            }
            set
            {
                this.companyAdress = value;
            }
        }
        public string Remarks
        {
            get
            {
                return this.remarks;
            }
            set
            {
                this.remarks = value;
            }
        }

        public ClientType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        // Constructors
        public Client()
        {}
        // list binnen krijgen 
        public Client(string name, List<ContactPerson> contactPersons, string vatnumber, List<Adress> companyAdress, string remarks, ClientType t)
        {
            this.Name = name;
            this.ContactPersons = contactPersons;
            this.Vat = vatnumber;
            this.CompanyAddress = companyAddress;
            this.Remarks = remarks;
            this.Type = type;
        }

        // Methods
    }
}