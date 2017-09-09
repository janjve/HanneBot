$filename = "HanneBot\Keys.config"
$newline = "`r`n"
If(-Not (Test-Path $filename)) {
    $keyset = '<appSettings>' + $newline
    $keyset += '  <add key="bot_token" value="ADD_MISSING_BOT_TOKEN"/>' + $newline
    # ...
    $keyset += '</appSettings>' + $newline
    $keyset | Out-File $filename
}