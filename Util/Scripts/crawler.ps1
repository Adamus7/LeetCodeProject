#$URL = $args[0]
$URL = "https://leetcode.com/problems/longest-palindromic-substring"

$gitArgs = @("config", "--get", "user.name")
$command = &"git" $gitArgs
$COMMENT_TAG = '//'
$COMMENT = ""

# Create an Browser COM object
$ie = New-Object -comobject InternetExplorer.Application
$ie.visible = $false
$ie.navigate($URL)

# Wait for the page to load
While( $ie.Busy -eq $true)
{
    Start-Sleep -Milliseconds 500
}

# Get the content 

$QuestionContent = ($ie.document.getElementsByTagName('meta') | Where {$_.getAttributeNode('name').Value -eq 'description'} ).content.Split("`n")
$QuestionTitle = ($ie.document.getElementsByTagName('div') | Where{ $_.className -eq ‘question-title clearfix’ }).innerText.Split('.')[1]
#$DIFFCULT = ($ie.document.getElementById('desktop-side-bar')).getElementsByTagName('span') | Where{  }
#$NG =  ($ie.document.body.getElementsByTagName('div') | where {$_.getAttributeNode('ng-controller').Value -eq 'AceCtrl as aceCtrl'} )
#$JSON = $NG.getAttributeNode('ng-init').Value
