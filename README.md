# ClipboardBase64Converter

Simple tool that allows to directly copy specified file to clipboard upon encoding it in Base64 format and paste clipboard contents as a file, upon decoding it from Base64.

Running without command line arguments brings simple window allowing to choose a file for encoding into clipboard or decode clipboard contents and save it as a file.
Running with an argument, checks if the argument is a file or a directory path. If a file path is detected, the tool encodes given file as Base64 and copies it to clipboard. If it's a directory path, the tool tries to decode clipboard content as Base64 and offers saving decoded file in given directory.

## Windows Context Menu entries
ContextMenu.reg file is a registry script that creates Windows Explorer context (RMB) menu entries. Edit it to set proper exe file location or save the exe file as C:\cbb64.exe
