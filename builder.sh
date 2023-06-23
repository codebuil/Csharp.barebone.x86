printf "\ec\e[44;37m\n"
mcs Program.cs -o program.exe
mono --aot=asmonly  program.exe
cat program.exe.s
