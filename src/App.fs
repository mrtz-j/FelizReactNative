module App

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Feliz.ReactNative

open Browser

[<Import("FontAwesome", from="@expo/vector-icons/FontAwesome")>]
let fontAwesome : ReactElement = jsNative

[<Import("StatusBar", from="expo-status-bar")>]
let expoStatusBar : ReactElement = jsNative

let placeholderImage: IImageSource = importDefault "../assets/images/background-image.png"

[<ReactComponent>]
let ImageViewer (imageSource: IImageSource) =
    Comp.image [
        prop.style [
            style.width 320
            style.height 440
            style.borderRadius 18
        ]
        prop.source imageSource
    ]
    
[<ReactComponent>]
let Button (label: string) (theme: string) =
    if theme = "primary" then
        Comp.view [
            prop.style [
               style.width 320
               style.height 68
               style.marginHorizontal 20
               style.alignItems.center
               style.justifyContent.center
               style.padding 3
               style.borderWidth 4
               style.borderColor "#ffd33d"
               style.borderRadius 18
            ]
            prop.children [
                Comp.pressable [
                    prop.style [
                        style.borderRadius 10
                        style.width 312
                        style.height 60
                        style.alignItems.center
                        style.justifyContent.center
                        style.flexDirection.row
                        style.backgroundColor "#fff"
                    ]
                    prop.onPress (fun _ -> console.log("You pressed a button."))
                    prop.children [
                        Comp.text [
                            prop.style [
                                style.color "#25292e"
                                style.fontSize 16.
                            ]
                            prop.text label
                        ]
                    ]
                ]
            ]
        ]
    else
        Comp.view [
            prop.style [
               style.width 320
               style.height 68
               style.marginHorizontal 20
               style.alignItems.center
               style.justifyContent.center
               style.padding 3
            ]
            prop.children [
                Comp.pressable [
                    prop.style [
                        style.borderRadius 10
                        style.width 312
                        style.height 60
                        style.width 100.
                        style.height 100.
                        style.alignItems.center
                        style.justifyContent.center
                        style.flexDirection.row
                    ]
                    prop.onPress (fun _ -> console.log("You pressed a button."))
                    prop.children [
                        Comp.text [
                            prop.style [
                                style.color.white
                                style.fontSize 16.
                            ]
                            prop.text label
                        ]
                    ]
                ]
            ]
        ]
        
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
                    ImageViewer placeholderImage
                ]
            ]
            Comp.view [
                prop.style [
                    style.flex 0.33
                    style.alignItems.center
                ]
                prop.children [
                    
                ]
            ]
            Button "Choose a photo" "primary"
            Button "Use this photo" "secondary"
            expoStatusBar
        ]
    ]