# Plex.NetUI - Declarative UI Components for ASP.NET Core MVC

Plex.NetUI is a Razor Class Library (RCL) that lets you compose UI using C# components. It ships a small CSS file for sensible defaults and requires no custom JavaScript.

## 1) Add the package

- Via NuGet (when published):
```bash
 dotnet add package Plex.NetUI
```

- Or reference the project locally:
```xml
<ItemGroup>
  <ProjectReference Include="..\Plex.NetUI\Plex.NetUI.csproj" />
</ItemGroup>
```

## 2) Include the CSS

Add this to your layout or page:
```html
<link href="~/_content/Plex.NetUI/uilibrary.css" rel="stylesheet" />
```
The `/_content/Plex.NetUI/` path is used by Razor Class Libraries for static web assets.

## 3) Use the components in a view

#### Namespaces:
```csharp
//Add name Spaces Like This
@using Plex.NetUI.Components
@using Plex.NetUI.Components.Table
@using Plex.NetUI.Components.Navigation
```

#### Compose and render:
In your use a c# code by using ```@{ //Tag }``` or inject below code directly in your endpoint like ```Index()``` etc.
```csharp
@{
    var ui = new VStack { ClassName = "vstack", Children =
    {
        new Navbar("Plex.NetUI Demo")
        {
            Children = { new Navigation { Children = { new NavItem("Home", "/") } } }
        },

        new HStack { Children =
        {
            new Card("Welcome") { Children = { new Text("Build UI with C# components.") } },
            new Card("Actions") { Children = { new Button("Click", "alert('Hello')") } }
        }},

        new Divider(),

        new Heading("Table", 2),
        new Table
        {
            Children =
            {
                new TableRow { Children = { new TableHeaderCell("Product"), new TableHeaderCell("Price") } },
                new TableRow { Children = { new TableCell("Laptop"), new TableCell("$999.99") } },
            }
        },

        new Divider(),

        new Heading("Form", 2),
        new Form { Children = { new Input("text", "Your name"), new Button("Submit", "alert('Submitted')") } },

        new Divider(),

        new Heading("Image & Link", 2),
        new HStack { Children =
        {
            new Image("https://via.placeholder.com/120", "Sample", 120, 120),
            new Link("Learn more", "https://example.com")
        } }
    }};
}
```

Don't forget ro add below code at end of file to render the page
```
@Html.Raw(ui.Render())
```

Or via extension method:
```csharp
@using Plex.NetUI.Extensions
@Html.RenderComponent(ui)
```

## 4) Available components (overview)

- Layout: `VStack`, `HStack`, `Container`
- Typography & content: `Heading`, `Text`, `Divider`, `Link`, `Image(src, alt, width?, height?)`
- Actions: `Button(text, onClick)`
- Forms: `Form`, `Input(type, placeholder)`
- Navigation: `Navbar(title)`, `Navigation`, `NavItem(text, href)`
- Tables: `Table`, `TableRow`, `TableHeaderCell`, `TableCell`

Notes:
- Set `ClassName = "vstack"` on `VStack` to enable vertical spacing via built-in CSS.
- `HStack` and `Table` include default classes (`hstack`, `table`).

## 5) Troubleshooting

- CSS not loading? Ensure the link is exactly `~/_content/Plex.NetUI/uilibrary.css` and the app references the library.
- If you changed the library assembly name, update the `/_content/{AssemblyName}` segment accordingly.

## Links

- Repository: @https://github.com/rehmnabdul/plex-net-ui
- Developer: @https://github.com/rehmnabdul
