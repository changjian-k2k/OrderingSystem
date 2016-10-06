using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class ClientForm : INotifyPropertyChanged
    {
        int _id;
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        string _name;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (this._name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }

            }
        }

        string _address;
        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                if (this._address != value)
                {
                    _address = value;
                    OnPropertyChanged(nameof(Address));
                }

            }
        }

        string _phone;
        public string Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                if (this._phone != value)
                {
                    _phone = value;
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }


        string _postcode;
        public String Postcode
        {
            get
            {
                return this._postcode;
            }
            set
            {
                if (this._postcode != value)
                {
                    _postcode = value;
                    OnPropertyChanged(nameof(Postcode));
                }
            }
        }


        string _addressee;
        public String Addressee
        {
            get
            {
                return this._addressee;
            }
            set
            {
                if (this._addressee != value)
                {
                    _addressee = value;
                    OnPropertyChanged(nameof(Addressee));
                }
            }
        }


        string _qq;
        public String QQ
        {
            get
            {
                return this._qq;
            }
            set
            {
                if (this._qq != value)
                {
                    _qq = value;
                    OnPropertyChanged(nameof(QQ));
                }
            }
        }

        public ClientForm()
        {
            Id = 0;
            Name = null;
            Address = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string strName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(strName));
            }
        }
    }
}
