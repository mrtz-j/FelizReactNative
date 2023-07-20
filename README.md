# Feliz React-Native

A Test app using F# with Fable and React-Native with Expo. Following this [guide](https://docs.expo.dev/tutorial/introduction/)

## How to run

### Install Fable

To install Fable run the following

```bash
dotnet tool restore
```

### Install npm-packages

Run

```bash
pnpm install
```

### Actually running it

1. Compile the F# to Javascript and watch for changes

```bash
dotnet fable watch ./src -o ./out
```
or from our `package.json`
```bash
pnpm start watch
```

2. Run the app (ios, android or web)

```bash
pnpm run web
```

3. Enjoy 🩹

## Acknowledgements

<https://github.com/martinmoec/fable-react-native-how-to>
