using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class Property
    {

        //Full property
        private string name;
        //automatic property is the short hand getter and setter
        public string Name {get; set;}

        //Read only
        public string ReadOnly { get; }

        //Read only with Initialization
        public string ReadOnlyStringWithInitialization { get; } = "Read Only String";

    }
}

/*
There are 4 types of properties
    _full property
        has variable name
        has both getter and setter
    _Automatic property
        shorthand for getter and setter
    _Read Only property
        read only variable
    _Read Only With Initialization
        read only with an initial value
*/