using System;

namespace csharp_vscode_pancake
{
    class Book
    {
        public string Title {get; set;}
        public string Author {get; set;}

        public bool _checkedOut {get; set;}
        
        //backing variable (usually private)
        private int _age {get; set;}
        //now the publicly facing version
        public int Age {
            get{return _age;}
            set{
                if(value >= 0 && value < 1000){
                    _age = value;
                } else {
                    throw new Exception("Age must be a positive number and younger than 1000 years");
                }
            }
        }
    }
}