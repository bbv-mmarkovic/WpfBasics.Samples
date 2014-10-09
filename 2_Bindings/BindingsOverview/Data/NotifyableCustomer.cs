// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotifyableCustomer.cs" company="bbv Software Services AG">
//   Copyright (c) 2014
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BindingsOverview.Data
{
    using System.ComponentModel;

    public class NotifyableCustomer : INotifyPropertyChanged
    {
        private int id;
        private string username;
        private string firstName;
        private string lastName;
        private string phone;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value != this.id)
                {
                    this.id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                if (value != this.username)
                {
                    this.username = value;
                    this.OnPropertyChanged("Username");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    this.OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    this.OnPropertyChanged("LastName");
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (value != this.phone)
                {
                    this.phone = value;
                    this.OnPropertyChanged("Phone");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}