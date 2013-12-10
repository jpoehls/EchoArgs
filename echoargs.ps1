echo "# `$PSCommandPath"
echo "$PSCommandPath"
echo ""

echo "# `$args"

$c = 1
foreach ($a in $args) {
    echo "[$c]: $a"
    $c++
}

echo ""

echo "# [System.Environment]::GetCommandLineArgs()"
$c = 0
foreach ($a in ([System.Environment]::GetCommandLineArgs())) {
    echo "[$c]: $a"
    $c++
}

echo ""
echo "# [System.Environment]::CommandLine"
echo ([System.Environment]::CommandLine)