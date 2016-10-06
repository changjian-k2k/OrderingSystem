using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class OrderingSystemForm : INotifyPropertyChanged
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

        int _clientID;
        public int ClientID
        {
            get
            {
                return this._clientID;
            }
            set
            {
                if (this._clientID != value)
                {
                    _clientID = value;
                    OnPropertyChanged(nameof(ClientID));
                }

            }
        }

        int _goodID;
        public int GoodID
        {
            get
            {
                return this._goodID;
            }
            set
            {
                if (this._goodID != value)
                {
                    _goodID = value;
                    OnPropertyChanged(nameof(GoodID));
                }

            }
        }

        decimal? _price;
        public decimal? Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if (this._price != value)
                {
                    _price = value;
                    OnPropertyChanged(nameof(Price));
                }

            }
        }

        int? _quantity;
        public int? Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if (this._quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }

            }
        }

        string _remark;
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                if (this._remark != value)
                {
                    _remark = value;
                    OnPropertyChanged(nameof(Remark));
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

        DateTime _orderDate;
        public DateTime OrderDate
        {
            get
            {
                return this._orderDate;
            }
            set
            {
                if (this._orderDate != value)
                {
                    _orderDate = value;
                    OnPropertyChanged(nameof(OrderDate));
                }

            }
        }

        DateTime _shipDate;
        public DateTime ShipDate
        {
            get
            {
                return this._shipDate;
            }
            set
            {
                if (this._shipDate != value)
                {
                    _shipDate = value;
                    OnPropertyChanged(nameof(ShipDate));
                }

            }
        }

        string _photo;
        public string Photo
        {
            get
            {
                return this._photo;
            }
            set
            {
                if (this._photo != value)
                {
                    _photo = value;
                    OnPropertyChanged(nameof(Photo));
                }

            }
        }

        string _paymentStatus;
        public string PaymentStatus
        {
            get
            {
                return this._paymentStatus;
            }
            set
            {
                if (this._paymentStatus != value)
                {
                    _paymentStatus = value;
                    OnPropertyChanged(nameof(PaymentStatus));
                }

            }
        }

        decimal? _discount;
        public decimal? Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                if (this._discount != value)
                {
                    _discount = value;
                    OnPropertyChanged(nameof(Discount));
                }

            }
        }

        decimal? _amount;
        public decimal? Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if (this._amount != value)
                {
                    _amount = value;
                    OnPropertyChanged(nameof(Amount));
                }

            }
        }

        public OrderingSystemForm()
        {
            Id = 0;
            ClientID = 0;
            GoodID = 0;
            Price = null;
            Quantity = null;
            Remark = null;
            Address = null;
            OrderDate = DateTime.Today;
            ShipDate = DateTime.Today;
            Photo = null;
            PaymentStatus = null;
            Discount = null;
            Amount = null;
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
