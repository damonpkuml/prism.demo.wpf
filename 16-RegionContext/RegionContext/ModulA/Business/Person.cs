using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace ModulA.Business {
    /// <summary>
    /// 主项目完全不知道子模块的业务，（可插拔）
    /// </summary>
    public class Person : BindableBase {
        private string _firstName;

        public string FirstName {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName;

        public string LastName {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }


        private int _age;

        public int Age {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        public override string ToString() {
            return $"FistName:{_firstName},LastName:{_lastName}";
        }
    }
}
