EchoArgs
========

Simple apps for testing argument parsing.

* C++ app
	* argv
	* GetCommandLineW()
	* CommandLineToArgvW()
* C# app
	* Environment.GetCommandLineArgs()
	* Environment.CommandLine
* Batch file
	* %CmdCmdLine%
	* %0
	* %*
* PowerShell script
	* $PSCommandPath
	* $args
	* [System.Environment]::GetCommandLineArgs()
	* [System.Environment]::CommandLine

Each app/script will echo all arguments passed in.