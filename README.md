# VisualStudioCodeReadability

Oliver Abraham
mail@oliver-abraham.de


## Abstract

This Visual Studio extension aligns properties to columns for better readability.
To use, select whole lines of c# code and issue the command "AlignCSharpProperties"
I recommend adding a keyboard shortcut.


## Example

Lets say you have written the following code:

        public int ID { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; } = 0.0;
        public DateTime CreatedAt { get; set; }

The Align command will format your code like this:

        public int      ID        { get; set; }
        public string   Name      { get; set; }
        public double   Amount    { get; set; } = 0.0;
        public DateTime CreatedAt { get; set; }


## Hosted at

https://github.com/OliverAbraham/


## License

This extension is published under GNU GPL v3 license.
https://choosealicense.com/licenses/gpl-3.0/
https://www.gnu.org/licenses/gpl-3.0.en.html


## Getting started

You'll find this extension on Visual Studio Marketplace. 
To install:
- open up Visual Studio
- go to 'manage Extensions'
- search for 'VisualStudioCodeReadability' and install
- go to keyboard shortcuts, search for VisualStudioCodeReadability
- assign a shortcut for the desired function

