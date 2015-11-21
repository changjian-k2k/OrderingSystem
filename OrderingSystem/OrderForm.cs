
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class OrderForm : INotifyPropertyChanged
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

        string _buyer;
        public string Buyer {
            get
            {
                return this._buyer;
            }
            set
            {
                if (this._buyer != value)
                {
                    _buyer = value;
                    OnPropertyChanged(nameof(Buyer));
                }
                
            }
        }

        string _good;
        public string Good
        {
            get
            {
                return this._good;
            }
            set
            {
                if (this._good != value)
                {
                    _good = value;
                    OnPropertyChanged(nameof(Good));
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

        string _goodColor;
        public string GoodColor
        {
            get
            {
                return this._goodColor;
            }
            set
            {
                if (this._goodColor != value)
                {
                    _goodColor = value;
                    OnPropertyChanged(nameof(GoodColor));
                }

            }
        }

        string _goodSize;
        public string GoodSize
        {
            get
            {
                return this._goodSize;
            }
            set
            {
                if (this._goodSize != value)
                {
                    _goodSize = value;
                    OnPropertyChanged(nameof(GoodSize));
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

        public OrderForm()
        {
            Id = 0;
            Buyer = null;
            Good = null;
            Price = null;
            Quantity = null;
            GoodColor = null;
            GoodSize = null;
            Remark = null;
            Address = null;
            OrderDate = DateTime.Today;
            ShipDate = DateTime.Today;
            Photo = null;
            PaymentStatus = null;
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
