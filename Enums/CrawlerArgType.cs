using CsvHelper.Configuration.Attributes;
using System.ComponentModel;

namespace ExportData.Enums;

public enum CrawlerArgType
{
    [Name("alert text")]
    [Description("text to check")]
    AlertText,

    [Name("answer")]
    [Description("The answer to give in response to the prompt pop-up")]
    Answer,

    [Name("attribute locator")]
    [Description("An element locator followed by an @ sign and then the name of the attribute, e.g. 'foo@bar'")]
    AttributeLocator,

    [Name("array variable name")]
    [Description("The name of a variable containing a JavaScript array")]
    ArrayVariableName,

    [Name("conditional expression")]
    [Description("JavaScript expression that returns a boolean result for use in control flow commands")]
    ConditionalExpression,

    [Name("coord string")]
    [Description("Specifies the x,y position (e.g., - 10,20) of the mouse event relative to the element found from a locator")]
    Coord,

    [Name("expected value")]
    [Description("The result you expect a variable to contain (e.g., true, false, or some other value)")]
    ExpectedValue,

    [Name("expression")]
    [Description("The value you'd like to store")]
    Expression,

    [Name("form locator")]
    [Description("An element locator for the form you want to submit")]
    FormLocator,

    [Name("window handle")]
    [Description("A handle representing a specific page (tab, or window)")]
    Handle,

    [Name("iterator variable name")]
    [Description("The name of the variable used when iterating over a collection in a looping control flow command (e.g., for each)")]
    IteratorVariableName,

    [Name("json")]
    [Description("A string representation of a JavaScript object")]
    Json,

    [Name("key sequence")]
    [Description("A sequence of keys to type, can be used to send key strokes (e.g. ${KEY_ENTER})")]
    KeySequence,

    [Name("locator")]
    [Description("An element locator")]
    Locator,

    [Name("locator of drag destination object")]
    [Description("The locator of an element whose location (e.g., the center-most pixel within it) will be the point where locator of object to be dragged is dropped")]
    LocatorOfDragDestinationObject,

    [Name("locator of object to be dragged")]
    [Description("The locator of element to be dragged")]
    LocatorOfObjectToBeDragged,

    [Name("loop limit")]
    [Description("Maximum number of times a looping control flow command can execute to protect against infinite loops")]
    LoopLimit,

    [Name("message")]
    [Description("The message to print")]
    Message,

    [Name("option")]
    [Description("An option locator, typically just an option label (e.g. \"John Smith\")")]
    OptionLocator,

    [Name("text")]
    [Description("An exact string match. Support for pattern matching is in the works. See https://github.com/SeleniumHQ/selenium-ide/issues/141 for details")]
    Pattern,

    [Name("region")]
    [Description("Specify a rectangle with coordinates and lengths (e.g., \"x: 257, y: 300, width: 462, height: 280\")")]
    Region,

    [Name("resolution")]
    [Description("Specify a window resolution using WidthxHeight. (e.g., 1280x800)")]
    Resolution,

    [Name("script")]
    [Description("The JavaScript snippet to run")]
    Script,

    [Name("select locator")]
    [Description("An element locator identifying a drop-down menu")]
    SelectLocator,

    [Name("test case")]
    [Description("Test case name from the project")]
    TestCase,

    [Name("text")]
    [Description("The text to verify")]
    Text,

    [Name("times")]
    [Description("The number of attempts a times control flow loop will execute the commands within its block")]
    Times,

    [Name("url")]
    [Description("The URL to open (may be relative or absolute)")]
    Url,

    [Name("value")]
    [Description("The value to type")]
    Value,

    [Name("variable name")]
    [Description("The name of a variable (without brackets). Used to either store an expression's result in or reference for a check (e.g., with 'assert' or 'verify')")]
    VariableName,

    [Name("wait time")]
    [Description("The amount of time to wait (in milliseconds)")]
    WaitTime,

    [Name("xpath")]
    [Description("The xpath expression to evaluate")]
    XPath
}
