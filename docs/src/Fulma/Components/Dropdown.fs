module Components.Dropdown

open Fable.Helpers.React
open Fulma
open Fulma.Elements
open Fulma.Components
open Fulma.Extra.FontAwesome

let basic () =
    Dropdown.dropdown [ Dropdown.IsHoverable ]
        [ div [ ]
            [ Button.button [ ]
                [ span [ ]
                    [ str "Dropdown" ]
                  Icon.faIcon [ Icon.Size IsSmall ] [ Fa.icon Fa.I.AngleDown ] ] ]
          Dropdown.menu [ ]
            [ Dropdown.content [ ]
                [ Dropdown.Item.a [ ] [ str "Item n°1" ]
                  Dropdown.Item.a [ ] [ str "Item n°2" ]
                  Dropdown.Item.a [ Dropdown.Item.IsActive true ] [ str "Item n°3" ]
                  Dropdown.Item.a [ ] [ str "Item n°4" ]
                  Dropdown.divider [ ]
                  Dropdown.Item.a [ ] [ str "Item n°5" ] ] ] ]

let view =
    Render.docPage [ Render.contentFromMarkdown
                        """
# Dropdown

*[Bulma documentation](http://bulma.io/documentation/components/dropdown/)*
                        """
                     Render.docSection
                        ""
                        (Widgets.Showcase.view basic (Render.getViewSource basic))
                     Render.contentFromMarkdown
                        """
### Properties

#### Dropdown
State:

- `Dropdown.IsActive true`
- `Dropdown.IsHoverable`

Alignment:

- `Dropdown.IsRight`

#### Dropdown item

State:

- `Dropdown.Item.IsActive true`
                        """ ]
