# Windows Linux Subsystem (WLS)

1. Password Reset - [Stack Overflow](https://askubuntu.com/questions/931940/unable-to-change-the-root-password-in-windows-10-wsl)

   1. If you forgot your password on WSL simply open your command prompt from windows by typing cmd on search.
   1. Then type `ubuntu config --default-user root` to set root as the default user for Linux Bash Shell.
   1. Then open the Linux Bash shell which will log you in as root without asking for password.
   1. Then use `passwd username` to reset the password of any user.
   1. Use `ubuntu config --default-user username` to reset back to your normal Linux user account.
  
## Installs

- [Microsoft WSL Install Guide](https://docs.microsoft.com/en-us/windows/wsl/install-win10)

- [Install WSL2 Kernel](https://docs.microsoft.com/en-us/windows/wsl/wsl2-kernel)

- Fresh WSL Installs may require:

   ```bash
   sudo apt update
   ```
