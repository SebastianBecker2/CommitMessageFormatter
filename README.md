# CommitMessageFormatter

[![Build status](https://ci.appveyor.com/api/projects/status/6vhd29id3ihixvq4/branch/master?svg=true)](https://ci.appveyor.com/project/SebastianBecker2/commitmessageformatter/branch/master)

A little tool to format git commit messages

When the app starts, it creates a tray icon in the windows taskbar.
Use the context menu or double click the tray icon to open the main dialog.
When the main dialog opens, it will try to format the text that is currently in the clipboard.
It then shows you the formatted text and copies the result into the clipboard.
Every change there copies the new text into the clipboard again.
You can use the Escape key to close the dialog immediately to return to the previously focused application.

Using the context menu of the tray icon, you can open the configuration dialog.
Allowing you to configure how the rules are applied. Pretty much based on [The seven rules of a great Git commit message](https://chris.beams.io/posts/git-commit/).
It will try to find the header line and separate it from the body (if there is one) by one empty line.
If the header line is too long, it gets postfixed by "[HEADER TOO LONG]".
The body lines are broken automatically to fit the proper length.
Pre-existing line breaks in the body are removed.

You can also define a global hotkey to open the main dialog.
This is useful when you are writing a commit message in your favorite git client.
Just follow these convenient steps:
1) Copy the message you wrote.
2) Use the global hotkey to open the main dialog.
3) Check the formatted message and make changes if necessary.
4) Close the main dialog with Escape.
5) Paste the properly formatted message into the favorite git client.

At last you can customize the way the main dialog will look.
When selecting the font, it searches for all monospaced fonts installed.
This takes 2 seconds when first opening the combobox.

Using the amazing [FatCow IconPack](http://www.fatcow.com/free-icons).
And the [WeCantSpell.Hunspell library](https://github.com/aarondandy/WeCantSpell.Hunspell/).
