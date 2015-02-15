// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainViewModel.cs" author="Marko Marković">
//   Copyright (c) 2015
//   
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   
//   http://www.apache.org/licenses/LICENSE-2.0
//   
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AsyncSample
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class MainViewModel : INotifyPropertyChanged
    {
        private string asyncContent;
        private string syncContent;

        public MainViewModel()
        {
            this.SyncContent = "...";
            this.AsyncContent = "...";

            this.SyncCommand = new RelayCommand(
                () =>
                {
                    this.SyncContent = DateTime.Now.ToLongTimeString();
                    Thread.Sleep(2000);
                    this.SyncContent = DateTime.Now.ToLongTimeString();
                });

            this.AsyncCommand = new AsyncRelayCommand(
                async x =>
                {
                    this.AsyncContent = DateTime.Now.ToLongTimeString();
                    await Task.Delay(2000);
                    this.AsyncContent = DateTime.Now.ToLongTimeString();
                });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string SyncContent
        {
            get
            {
                return this.syncContent;
            }

            set
            {
                this.syncContent = value;
                this.OnPropertyChanged();
            }
        }

        public string AsyncContent
        {
            get
            {
                return this.asyncContent;
            }

            set
            {
                this.asyncContent = value;
                this.OnPropertyChanged();
            }
        }

        public ICommand SyncCommand { get; private set; }
        
        public ICommand AsyncCommand { get; private set; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}