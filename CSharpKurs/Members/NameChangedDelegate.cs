using System;
using System.Collections.Generic;
using System.Text;

namespace Members
{
    //public delegate void NameChangedDelegate(string existingName, string newName);
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);

}
