## Fixing MimeTypes for Windows

### Example

If you open regedit and go to the `HKEY_CLASSES_ROOT` there should be a key `.css/Content Type` with value `text/css`.

If there is a working, Windows machine you could export the `HKEY_CLASSES_ROOT` and then import it into the broken one although make sure you backup the registry first.

### Values

| Extension | Value |
| --- | --- |
| .css | text/css |
| .js | application/javascript |
