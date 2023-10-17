﻿namespace HelloProgrammerExam
{
  public  class PropertiesandEncapsulation
    {
        //this is field
        private string name;
        private string value;


        //this is property with set nad get methods
        public string Name { get; set; }
        public string Description { get; set; }

    }

    /*Why Encapsulation?
Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
Fields can be made read-only (if you only use the get method),
    or write-only (if you only use the set method)
Flexible: the programmer can change one part of the code
    without affecting other parts
Increased security of data*/


}