# VisualStudioCodeReadability

![](https://img.shields.io/github/downloads/oliverabraham/VisualStudioCodeAlignment/total) ![](https://img.shields.io/github/license/oliverabraham/VisualStudioCodeAlignment) ![](https://img.shields.io/github/languages/count/oliverabraham/VisualStudioCodeAlignment) ![GitHub Repo stars](https://img.shields.io/github/stars/oliverabraham/VisualStudioCodeAlignment?label=repo%20stars) ![GitHub Repo stars](https://img.shields.io/github/stars/oliverabraham?label=user%20stars)


## OVERVIEW


This Visual Studio extension aligns properties to columns for better readability.
To use, select whole lines of c# code and issue the command "AlignCSharpProperties"
I recommend adding a keyboard shortcut.


## LICENSE

Licensed under Apache licence.
https://www.apache.org/licenses/LICENSE-2.0


## Compatibility

The nuget package was build with DotNET Framework 4.8.


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



## AUTHOR

Oliver Abraham, mail@oliver-abraham.de, https://www.oliver-abraham.de

Please feel free to comment and suggest improvements!



## SOURCE CODE

The source code is hosted at:
https://github.com/OliverAbraham/VisualStudioCodeAlignment



## Getting started

You'll find this extension on Visual Studio Marketplace. 
To install:
- open up Visual Studio
- go to 'manage Extensions'
- search for 'VisualStudioCodeReadability' and install
- go to keyboard shortcuts, search for VisualStudioCodeReadability
- assign a shortcut for the desired function



# MAKE A DONATION !

If you find this application useful, buy me a coffee!
I would appreciate a small donation on https://www.buymeacoffee.com/oliverabraham

<a href="https://www.buymeacoffee.com/app/oliverabraham" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" ></a>

