# MauiTestApp

problem: the file AppResource/js/thirdparty/emoji-popover.es.js does not get included in the resource storage when the app is built
how to test: 
    when the app starts, click the buttom "Click Me", look in the Output window to see the list of embedded resource file names
    you can see that the emoji-popover-es.js is missing from the list       