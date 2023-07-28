# Bash / Global

Bash setup and scripts I've written to re-use.

## macOS Setup

1. Create a `.zsh_my_global_scripts` folder next to `.zshrc`
1. Add the following to `.zshrc`
    ``` bash
    # Add Custom Scripts
    export PATH=".zsh_my_global_scripts:$PATH"
    ```
1. Enable writes for files in `.zsh_my_global_scripts` with `chmod -R 777 *` 

## Windows Setup

1. Add `.bashrc` and `.bash_profile` to `~`
1. Create a `~\bin` folder and add functions there.

## Functions

| Name | Description |
| ---  | ---         |
| dotnet-sln-folder-add | Adds a project (.csproj) to all solutions (.sln) in current directory. |
| git-chmod | Grants execute in git to all files with specified extension. |
| git-reset-file | A script that resets a file to the what it is on master. |
