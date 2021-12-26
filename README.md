# VisualStudioCodeAlignment

Oliver Abraham
mail@oliver-abraham.de


## Abstract

This Visual Studio extension aligns properties to columns for better readability.

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
