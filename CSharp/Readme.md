#Lap Around Visual Studio 2015

##Manuscript for presentation

	2. C# 6.0 and VS2015 features 
		a. https://roslyn.codeplex.com/wikipage?title=Language%20Feature%20Status  
		b. Start with 1-...
		c. OldClass -> NewClass
			i. Getter Only,  
			ii. Initialize , new syntax
				1) Also see different forms of initialization, combining and chaining
				2) Can also initialize in ctor
			iii. Make a change to show the Roslyn editor playing along
				1) Show compiler errors coming and going, following the editor a few seconds later
			iv. Show string literals in same class
			v. Open StringLiterals.cs
				1) Show different ways of interpolation, including formatting
				2) Verify with the test
				3) Show MD file with links
		d. Go to 2
		e. Open OldTriangle
			i. Show Triangle, the new way
			ii. Point out expression body and using Math
			iii. Open TriangleEx, Show different ways method and property member expression bodies
			iv. Show CustomerCollection to show the indexer using expression body.
		f. Go to 3
		g. Show parameterless struct constructor, and show MD file.
		h. Goto 4  (and into debugging)
			i. Show GenerateCourseTitle
				1) Show Teacher and Course classes
				2) Show old code, GenerateCourseTitle method
				3) Set breakpoint into Course Teacher method  (Property Breakpoint)
				4) Show Testcode CheckNullOldWay
				5) Then show new code   GenerateCourseTitleNew method
				6) Show TestCode CheckNullNewWay, set breakpoint inside the new method, on return. 
				7) Run the code
				8) Show what the title is, and how it is formatted
				9) Walk through the methods and the testsfor CheckNull*Way
				10) Choose CheckChangingTeacher, and start debugging, with breakpoint on first line
					a) Step through the 2nd ChangeTeacher call
				11) Explain the dispose code too 
				12) Vis koden for CheckChangingTeacherVerified.
					a) Notify den bruker lang tid.
					b) Set breakpoint på første linje
					c) Step over each line and notify how long time each takes (Live Performance 1)
					d) Go back and into the long method, until the fault is found
					e) Show call stack on codemap, keep it open as we step further through the code
					f) Codemap the test method, and use Show methods this calls in codemap.
					g) Talk about this, and then do a  Profile Tests to show quickly how to locate it.
		i. Goto 5
			i. Show code for OldExceptionProne
			ii. Show code for NewExceptionProne and explain how it works
			iii. Show code for the tests and run the code
		j. Goto 6
			i. Find the test code and step into the sut.
			ii. Show the nameof code
			iii. Explain it works on both methods and parameters
			iv. Show the md
		k. Goto 7
			i. Show old and new dictionary code
				1) Mark that the Find... Method is also simplified.
			ii. Show more complex code, with new'ing up code too
		l. Goto d10-debugging
			i. Jump into VerifyPaymentToTeachers;
				1) Change cost estimate to 200, so test break
				2) Go into the Due method, and set the breakpoint there
					a) Show the new quick settings menu
					b) First with tracepoints
					c) Then to break
				3) Goto FlexibleTeacher in Study.cs
					a) Talk about FlexibleTeacher
					b) Do a smart unit test on that one 
					c) Save them, see the generated ones, run them, check coverage
		m. Goto d11-DebugLambdas
			i. Stop code at top level code in   CheckDict  breakpoint and use the watch window, show how lambdas can be used there
				1) Use sut.Where(p=>p.Name=="Trond")
			ii. Single step through the lambda expression there
		n. Goto d12 - Memory
			i. Open memory test  InMemoryLand
			ii. Set breakpoiint near end
			iii. Start Diagnostic tool, see live memory tracking
			iv. Se på snapshotted også, og hvilke objekter som ligger der. 
		o. Stuff that didnt really make it
			i. Primary ctors
			ii. Declaration expressions 
		p. If time:
			i. Open branch codecracker, and show analyzers
	3. Project K
		a. Clean output, Restart VS, kill all processes.
		b. Switch branch til K-1
		c. Start med K_1_Library
		d. Vis project .json
		e. Vis web prosjektet
			i. Show the other files
			ii. Show the Task Runner window
		f. Show the command line and kvm, kpm and k
        g. Add the XUnit.KRunner nuget package
        h. Add XUnit by adding the command "test" with value "Xunit.KRunner" to project.json
        i. Show that the test runs in VS test explorer, along with all the other tests
		g. Open cmd window:  Go to a test folder, run the k test command, and show it runs the test


Debugger settings on breakpoint
![alt text](C:\Users\Terje\source\repos\CommunityDay\VS2015-1\CSharp\CSharp\images\debug1.png)

Note: Use string interpolation syntax in the message field to display content of class members.


##Organisation of the sample code

###Project CSharp

This is the demo code, organised in folders, each corresponding to small set of features.  
See the manuscript above for information on what it does.

###Project CSHarpTests

This is a corresponding unit test project. Some of the demos use this either in combination with CSharp or alone.

###Project CSHarp.Tests

This is a test project generated by Smart Unit Testing.
The code for FlexibleTeacherTest.cs can be deleted and regenerated. 



