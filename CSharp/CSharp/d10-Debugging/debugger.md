###Debugger enhancements

##Setting breakpoints on auto properties

[Blogpost by Daniel Moth](http://blogs.msdn.com/b/visualstudioalm/archive/2014/11/14/set-breakpoints-on-auto-implemented-properties-with-visual-studio-2015.aspx)

It just works !

(In VS2013, you can use function breakpoints)

[Breakpoint configuration](http://blogs.msdn.com/b/visualstudioalm/archive/2014/10/06/new-breakpoint-configuration-experience.aspx)


[Support for debugging lambdas](http://blogs.msdn.com/b/visualstudioalm/archive/2014/11/12/support-for-debugging-lambda-expressions-with-visual-studio-2015.aspx)

In order to enable Live Memory Profiling:

    [HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\14.0_Config\FeatureFlags\DiagnosticsHub\PerformanceDebuggerEnabled]
    "Value"=dword:00000001

