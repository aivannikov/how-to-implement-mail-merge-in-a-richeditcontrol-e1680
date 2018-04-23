using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MailMerge {
    class SampleData : ArrayList {
        public SampleData() {
            Add(new AddresseeRecord("Andrew", "XYZ Inc.", "Tullamore Way, 21", 36));
            Add(new AddresseeRecord("Benny", "ABC Ltd.", "Casablanca Rd., 46", 21));
            Add(new AddresseeRecord("Jose", "CASA S.A.", "Paseo di Ronda, 88", 45));


        }
    }

    public class AddresseeRecord {
        private int fAge;
        private string fName;
        private string fCompany;
        private string fAddress;

        public int Age {
            get { return fAge; }
            set { fAge = value; }
        }
        public string Name {
            get { return fName; }
            set { fName = value; }
        }
        public string Company {
            get { return fCompany; }
            set { fCompany = value; }
        }
        public string Address {
            get { return fAddress; }
            set { fAddress = value; }
        }

        public AddresseeRecord(string fName, string fCompany, string fAddress, int fAge) {
            this.fName = fName;
            this.fAge = fAge;
            this.fCompany = fCompany;
            this.fAddress = fAddress;
        }
    }
}
