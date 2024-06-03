# Doxygen

- [https://doxygen.nl/](https://doxygen.nl/)

> Code Documentation. Automated.
> Free, open source, cross-platform.

In doxygen one has the possibility to define his own HTML header file, best based on the default HTML header file.

To obtain the default HTML header file, syntax:

`doxygen -w html headerFile footerFile styleSheetFile [configFile]`

in the headerFile insert in the head part a line like:

`<link rel="icon" href="$relpath^my_icon.ico" type="image/x-icon" />`

Note: that the `$relpath^` part is necessary especially in case of `CREATE_SUBDIRS` is set.

Furthermore in the configuration file (Doxyfile) you have to set:

```bash
HTML_HEADER            = headerFile
HTML_EXTRA_FILES       += my_icon.ico
```

Of course the standard restrictions regarding favicons still apply (regarding support by browsers etc.).

https://stackoverflow.com/a/18355240/2895831
