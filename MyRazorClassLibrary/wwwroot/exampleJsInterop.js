// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function showPrompt(message) {
    message = "Hey " + message + ", This is a javascript fn invoked from c# code";
    return alert(message);
}
