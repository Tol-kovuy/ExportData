using CsvHelper.Configuration.Attributes;
using ExportData.Attributs;
using System.ComponentModel;
using NameAttribute = ExportData.Attributs.NameAttribute;

namespace ExportData.Enums;

public enum CommandType
{
    [Name("accept alert")]
    [Description("Affects a currently showing alert. This command instructs Selenium to accept it.")]
    AceptAlert,

    [Name("accept confirmation")]
    [Description("Affects a currently showing confirmation alert. This command instructs Selenium to accept it.")]
    AcceptConfirmation,

    [Name("add selection")]
    [Description("Add a selection to the set of options in a multi-select element.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    AddSelection,

    [Name("answer prompt")]
    [Description("Affects a currently showing alert prompt. This command instructs Selenium to provide the specified answer to it.")]
    [ArgumentTypeAttribute(CrawlerArgType.Answer)]
    AnswerPrompt,

    [Name("assert")]
    [Description("Check that a variable is an expected value. The variable's value will be converted to a string for comparison. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.VariableName)]
    [ValueTypeAttribute(CrawlerArgType.ExpectedValue)]
    Assert,

    [Name("assert alert")]
    [Description("Confirm that an alert has been rendered with the provided text. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.AlertText)]
    AssertAlert,

    [Name("assert checked")]
    [Description("Confirm that the target element has been checked. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    AssertChecked,

    [Name("assert confirmation")]
    [Description("Confirm that a confirmation has been rendered. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.AlertText)]
    AssertConfirmation,

    [Name("assert editable")]
    [Description("Confirm that the target element is editable. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    AssertEditable,

    [Name("assert element present")]
    [Description("Confirm that the target element is present somewhere on the page. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    AssertElementPresent,

    [Name("assert element not present")]
    [Description("Confirm that the target element is not present anywhere on the page. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    AssertElementNotPresent,

    [Name("assert not checked")]
    [Description("Confirm that the target element has not been checked. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    AssertNotChecked,

    [Name("assert not editable")]
    [Description("Confirm that the target element is not editable. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    AssertNotEditable,

    [Name("assert not selected value")]
    [Description("Confirm that the value attribute of the selected option in a dropdown element does not contain the provided value. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.SelectLocator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    AssertNotSelectedValue,

    [Name("assert not text")]
    [Description("Confirm that the text of an element does not contain the provided value. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    AssertNotText,

    [Name("assert prompt")]
    [Description("Confirm that a JavaScript prompt has been rendered. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.AlertText)]
    AssertPrompt,

    [Name("assert selected value")]
    [Description("Confirm that the value attribute of the selected option in a dropdown element contains the provided value. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.SelectLocator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    AssertSelectedValue,

    [Name("assert selected label")]
    [Description("Confirm that the label of the selected option in a dropdown element contains the provided value. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.SelectLocator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    AssertSelectedLabel,

    [Name("assert text")]
    [Description("Confirm that the text of an element contains the provided value. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    AssertText,

    [Name("assert title")]
    [Description("Confirm the title of the current page contains the provided text. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Pattern)]
    AssertTitle,

    [Name("assert value")]
    [Description("Confirm the (whitespace-trimmed) value of an input field (or anything else with a value parameter). For checkbox/radio elements, the value will be \"on\" or \"off\" depending on whether the element is checked or not. The test will stop if the assert fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    AssertValue,

    [Name("dismiss confirmation")]
    [Description("Affects a currently showing confirmation alert. This command instructs Selenium to dismiss it.")]
    DismissConfirmation,

    [Name("dismiss prompt")]
    [Description("Affects a currently showing alert prompt. This command instructs Selenium to dismiss it.")]
    DismissPrompt,

    [Name("check")]
    [Description("Check a toggle-button (checkbox/radio).")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    Check,

    [Name("click")]
    [Description("Clicks on a target element (e.g., a link, button, checkbox, or radio button).")]
    [ArgumentTypeAttribute(    CrawlerArgType.Locator)]
    Click,

    [Name("click at")]
    [Description("Clicks on a target element (e.g., a link, button, checkbox, or radio button). The coordinates are relative to the target element (e.g., 0,0 is the top left corner of the element) and are mostly used to check effects that rely on them, for example, the material ripple effect.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Coord)]
    ClickAt,

    [Name("close")]
    [Description("Closes the current window. There is no need to close the initial window, IDE will re-use it; closing it may cause a performance penalty on the test.")]
    Close,

    [Name("debugger")]
    [Description("Breaks the execution and enters the debugger")]
    Debugger,

    [Name("do")]
    [Description("Create a loop that executes the proceeding commands at least once. Terminate the branch with the repeat if command.")]
    Do,

    [Name("double click")]
    [Description("Double clicks on an element (e.g., a link, button, checkbox, or radio button).")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    DoubleClick,

    [Name("double click at")]
    [Description("Double clicks on a target element (e.g., a link, button, checkbox, or radio button). The coordinates are relative to the target element (e.g., 0,0 is the top left corner of the element) and are mostly used to check effects that rely on them, for example, the material ripple effect.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Coord)]
    DoubleClickAt,

    [Name("drag and drop to object")]
    [Description("Drags an element and drops it on another element.")]
    [ArgumentTypeAttribute(CrawlerArgType.LocatorOfObjectToBeDragged)]
    [ValueTypeAttribute(CrawlerArgType.LocatorOfDragDestinationObject)]
    DragAndDropToObject,

    [Name("echo")]
    [Description("Prints the specified message. Useful for debugging.")]
    [ArgumentTypeAttribute(CrawlerArgType.Message)]
    Echo,

    [Name("edit content")]
    [Description("Sets the value of a content editable element as if you typed in it.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Value)]
    EditContent,

    [Name("else")]
    [Description("Part of an if block. Execute the commands in this branch when an if and/or else if condition are not met. Terminate the branch with the end command.")]
    Else,

    [Name("else if")]
    [Description("Part of an if block. Execute the commands in this branch when an if condition has not been met. Terminate the branch with the end command.")]
    [ArgumentTypeAttribute(CrawlerArgType.ConditionalExpression)]
    ElseIf,

    [Name("end")]
    [Description("Terminates a control flow block for if, while, and times.")]
    End,

    [Name("execute script")]
    [Description("Executes a snippet of JavaScript in the context of the currently selected frame or window. The script fragment will be executed as the body of an anonymous function. To store the return value, use the 'return' keyword and provide a variable name in the value input field.")]
    [ArgumentTypeAttribute(CrawlerArgType.Script)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    ExecuteScript,

    [Name("execute async script")]
    [Description("Executes an async snippet of JavaScript in the context of the currently selected frame or window. The script fragment will be executed as the body of an anonymous function and must return a Promise. The Promise result will be saved on the variable if you use the 'return' keyword.")]
    [ArgumentTypeAttribute(CrawlerArgType.Script)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    ExecuteAsyncScript,

    [Name("for each")]
    [Description("Create a loop that executes the proceeding commands for each item in a given collection.")]
    [ArgumentTypeAttribute(CrawlerArgType.ArrayVariableName)]
    [ValueTypeAttribute(CrawlerArgType.IteratorVariableName)]
    ForEach,

    [Name("if")]
    [Description("Create a conditional branch in your test. Terminate the branch with the end command.")]
    [ArgumentTypeAttribute(CrawlerArgType.ConditionalExpression)]
    If,

    [Name("mouse down")]
    [Description("Simulates a user pressing the left mouse button (without releasing it yet).")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    MouseDown,

    [Name("mouse down at")]
    [Description("Simulates a user pressing the left mouse button (without releasing it yet) at the specified location.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Coord)]
    MouseDownAt,

    [Name("mouse move at")]
    [Description("Simulates a user pressing the mouse button (without releasing it yet) on the specified element.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Coord)]
    MouseMoveAt,

    [Name("mouse out")]
    [Description("Simulates a user moving the mouse pointer away from the specified element.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    MouseOut,

    [Name("mouse over")]
    [Description("Simulates a user hovering a mouse over the specified element.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    MouseOver,

    [Name("mouse up")]
    [Description("Simulates the event that occurs when the user releases the mouse button (e.g., stops holding the button down).")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    MouseUp,

    [Name("mouse up at")]
    [Description("Simulates the event that occurs when the user releases the mouse button (e.g., stops holding the button down) at the specified location.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Coord)]
    MouseUpAt,

    [Name("open")]
    [Description("Opens a URL and waits for the page to load before proceeding. This accepts both relative and absolute URLs.")]
    [ArgumentTypeAttribute(CrawlerArgType.Url)]
    Open,

    [Name("pause")]
    [Description("Wait for the specified amount of time.")]
    [ArgumentTypeAttribute(CrawlerArgType.WaitTime)]
    Pause,

    [Name("remove selection")]
    [Description("Remove a selection from the set of selected options in a multi-select element using an option locator.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.OptionLocator)]
    RemoveSelection,

    [Name("repeat if")]
    [Description("Terminate a 'do' control flow branch conditionally. If the result of the provided conditional expression is true, it starts the do loop over. Otherwise, it ends the loop.")]
    [ArgumentTypeAttribute(CrawlerArgType.ConditionalExpression)]
    [ValueTypeAttribute(CrawlerArgType.LoopLimit)]
    RepeatIf,

    [Name("run")]
    [Description("Runs a test case from the current project.")]
    [ArgumentTypeAttribute(CrawlerArgType.TestCase)]
    Run,

    [Name("run script")]
    [Description("Creates a new 'script' tag in the body of the current test window and adds the specified text into the body of the command. Beware that JS exceptions thrown in these script tags aren't managed by Selenium, so you should probably wrap your script in try/catch blocks if there is any chance that the script will throw an exception.")]
    [ArgumentTypeAttribute(CrawlerArgType.Script)]
    RunScript,

    [Name("select")]
    [Description("Select an element from a drop-down menu using an option locator. Option locators provide different ways of specifying a select element (e.g., label=, value=, id=, index=). If no option locator prefix is provided, a match on the label will be attempted.")]
    [ArgumentTypeAttribute(CrawlerArgType.SelectLocator)]
    [ValueTypeAttribute(CrawlerArgType.OptionLocator)]
    Select,

    [Name("select frame")]
    [Description("Selects a frame within the current window. You may invoke this command multiple times to select a nested frame. NOTE: To select the parent frame, use 'relative=parent' as a locator. To select the top frame, use 'relative=top'. You can also select a frame by its 0-based index number (e.g., select the first frame with 'index=0', or the third frame with 'index=2').")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    SelectFrame,

    [Name("select window")]
    [Description("Selects a popup window using a window locator. Once a popup window has been selected, all commands will go to that window. Window locators use handles to select windows.")]
    [ArgumentTypeAttribute(CrawlerArgType.Handle)]
    SelectWindow,

    [Name("send keys")]
    [Description("Simulates keystroke events on the specified element, as though you typed the value key-by-key. This simulates a real user typing every character in the specified string; it is also bound by the limitations of a real user, like not being able to type into invisible or read-only elements. This is useful for dynamic UI widgets (like auto-completing combo boxes) that require explicit key events. Unlike the simple 'type' command, which forces the specified value into the page directly, this command will not replace the existing content.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.KeySequence)]
    SendKeys,

    [Name("set speed")]
    [Description("Set execution speed (e.g., set the millisecond length of a delay which will follow each Selenium operation). By default, there is no such delay, e.g., the delay is 0 milliseconds. This setting is global and will affect all test runs until changed.")]
    [ArgumentTypeAttribute(CrawlerArgType.WaitTime)]
    SetSpeed,

    [Name("set window size")]
    [Description("Set the browser's window size, including the browser's interface.")]
    [ArgumentTypeAttribute(CrawlerArgType.Resolution)]
    SetWindowSize,

    [Name("store")]
    [Description("Save a target string as a variable for easy re-use.")]
    [ArgumentTypeAttribute(CrawlerArgType.Text)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    Store,

    [Name("store attribute")]
    [Description("Gets the value of an element attribute. The value of the attribute may differ across browsers (this is the case for the 'style' attribute, for example).")]
    [ArgumentTypeAttribute(CrawlerArgType.AttributeLocator)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    StoreAttribute,

    [Name("store element count")]
    [Description("Gets the number of nodes that match the specified locator (e.g., 'xpath=//table' would give the number of tables).")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    StoreElementCount,  

    [Name("store json")]
    [Description("Save JSON as an object on a variable")]
    [ArgumentTypeAttribute(CrawlerArgType.Json)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    StoreJson,

    [Name("store text")]
    [Description("Gets the text of an element and stores it for later use. This works for any element that contains text.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    StoreText,

    [Name("store title")]
    [Description("Gets the title of the current page.")]
    [ArgumentTypeAttribute(CrawlerArgType.VariableName)]
    StoreTitle,

    [Name("store value")]
    [Description("Gets the value of an element and stores it for later use. This works for any input type element.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.VariableName)]
    StoreValue,

    [Name("store window handle")]
    [Description("Gets the handle of the current page.")]
    [ArgumentTypeAttribute(CrawlerArgType.Handle)]
    StoreWindowHandle,

    [Name("times")]
    [Description("Create a loop that executes the proceeding commands n number of times.")]
    [ArgumentTypeAttribute(CrawlerArgType.Times)]
    [ValueTypeAttribute(CrawlerArgType.LoopLimit)]
    Times,

    [Name("type")]
    [Description("Sets the value of an input field, as though you typed it in. Can also be used to set the value of combo boxes, check boxes, etc. In these cases, the value should be the value of the option selected, not the visible text. Chrome only: If a file path is given, it will be uploaded to the input (for type=file). NOTE: XPath locators are not supported.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Value)]
    Type,

    [Name("uncheck")]
    [Description("Uncheck a toggle-button (checkbox/radio).")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    Uncheck,

    [Name("verify")]
    [Description("Soft assert that a variable is an expected value. The variable's value will be converted to a string for comparison. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.VariableName)]
    [ValueTypeAttribute(CrawlerArgType.ExpectedValue)]
    Verify,

    [Name("verify checked")]
    [Description("Soft assert that a toggle-button (checkbox/radio) has been checked. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    VerifyChecked,

    [Name("verify editable")]
    [Description("Soft assert whether the specified input element is editable (e.g., hasn't been disabled). The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    VerifyEditable,

    [Name("verify element present")]
    [Description("Soft assert that the specified element is somewhere on the page. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    VerifyElementPresent,

    [Name("verify element not present")]
    [Description("Soft assert that the specified element is not somewhere on the page. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    VerifyElementNotPresent,

    [Name("verify not checked")]
    [Description("Soft assert that a toggle-button (checkbox/radio) has not been checked. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    VerifyNotChecked,

    [Name("verify not editable")]
    [Description("Soft assert whether the specified input element is not editable (e.g., has been disabled). The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    VerifyNotEditable,

    [Name("verify not selected value")]
    [Description("Soft assert that the expected element has not been chosen in a select menu by its option attribute. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.SelectLocator)]
    [ValueTypeAttribute(CrawlerArgType.OptionLocator)]
    VerifyNotSelectedValue,

    [Name("verify not text")]
    [Description("Soft assert that the text of an element is not present. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Text)]
    VerifyNotText,

    [Name("verify selected label")]
    [Description("Soft assert the visible text for a selected option in the specified select element. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.SelectLocator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    VerifySelectedLabel,

    [Name("verify selected value")]
    [Description("Soft assert that the expected element has been chosen in a select menu by its option attribute. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.SelectLocator)]
    [ValueTypeAttribute(CrawlerArgType.OptionLocator)]
    VerifySelectedValue,

    [Name("verify text")]
    [Description("Soft assert the text of an element is present. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Text)]
    VerifyText,

    [Name("verify title")]
    [Description("Soft assert the title of the current page contains the provided text. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Text)]
    VerifyTitle,

    [Name("verify value")]
    [Description("Soft assert the (whitespace-trimmed) value of an input field (or anything else with a value parameter). For checkbox/radio elements, the value will be 'on' or 'off' depending on whether the element is checked or not. The test will continue even if the verify fails.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Pattern)]
    VerifyValue,

    [Name("wait for element editable")]
    [Description("Wait for an element to be editable.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.WaitTime)]
    WaitForElementEditable,

    [Name("wait for element not editable")]
    [Description("Wait for an element to not be editable.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.WaitTime)]
    WaitForElementNotEditable,

    [Name("wait for element not present")]
    [Description("Wait for a target element to not be present on the page.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.WaitTime)]
    WaitForElementNotPresent,

    [Name("wait for element not visible")]
    [Description("Wait for a target element to not be visible on the page.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.WaitTime)]
    WaitForElementNotVisible,

    [Name("wait for element present")]
    [Description("Wait for a target element to be present on the page.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.WaitTime)]
    WaitForElementPresent,

    [Name("wait for element visible")]
    [Description("Wait for a target element to be visible on the page.")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.WaitTime)]
    WaitForElementVisible,

    [Name("wait for text")]
    [Description("Wait until the text of an element is present")]
    [ArgumentTypeAttribute(CrawlerArgType.Locator)]
    [ValueTypeAttribute(CrawlerArgType.Text)]
    WaitForText,

    [Name("while")]
    [Description("Create a loop that executes the proceeding commands repeatedly for as long as the provided conditional expression is true.")]
    [ArgumentTypeAttribute(CrawlerArgType.ConditionalExpression)]
    [ValueTypeAttribute(CrawlerArgType.LoopLimit)]
    While
}
