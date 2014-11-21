###NameOf operator

[See more info](https://roslyn.codeplex.com/discussions/570551)

From this link, some examples:

```html
// MVC Action links
<%= Html.ActionLink("Sign up",
             @typeof(UserController),
             @nameof(UserController.SignUp))
%>
```

```
// INotifyPropertyChanged

int p {

    get { return this._p; }

    set { this._p = value; PropertyChanged(this, new PropertyChangedEventArgs(nameof(this.p)); }

}

```

```
    // also allowed: just nameof(p)

    // XAML dependency property

    public static DependencyProperty AgeProperty = DependencyProperty.Register(nameof(Age), typeof(int), typeof(C));

    // Logging

    void f(int i) {

        Log(nameof(f), "method entry");

    }
```

```
// Attributes

[DebuggerDisplay("={" + nameof(getString) + "()}")]

class C {

    string getString() { ... }

}
```
