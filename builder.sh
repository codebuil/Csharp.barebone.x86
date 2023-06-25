printf "\ec\e[44;37m\n"
mcs $1 -o $1.exe
mono --aot=asmonly  $1.exe
cat $1.exe.s
