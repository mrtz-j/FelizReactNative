module App

open Feliz
open Fable.Core.JsInterop
open Feliz.ReactNative

let placeholderImage: IImageSource = importDefault "../assets/images/background-image.png"

[<ReactComponent>]
let App() =
    Comp.view [
        prop.style [
            style.flex 1.
            style.justifyContent.center
            style.alignItems.center
            style.backgroundColor "#25292e"
        ]
        prop.children [
            Comp.view [
                prop.style [
                    style.flex 1.
                    style.paddingTop 58
                ]
                prop.children [
                    Comp.image [
                        prop.style [
                            style.width 320
                            style.height 440
                            style.borderRadius 18
                        ]
                        prop.source placeholderImage
                    ]
                ]
            ]
            Comp.text [
                prop.style [
                    style.color.white
                ]
                prop.text "Hello World!"
            ]
            Comp.statusBar [
                prop.barStyle.default'
            ]
        ]
    ]