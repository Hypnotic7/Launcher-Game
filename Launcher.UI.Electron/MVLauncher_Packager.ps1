param([parameter(mandatory = $false,valuefrompipeline = $true, helpmessage = 'type of version upgrade')] [string] $typeofversionupgrade = 'patch',
      [parameter(mandatory = $false,valuefrompipeline = $true, helpmessage = 'update to git release')] [bool] $updatetogitrelease = $false)

#major 1.0.0
#minor 0.1.0
#patch 0.0.1

function packagebuild(){
  Invoke-Expression("npm run build")
}

function versionupgrade($versionType){
  Invoke-Expression("npm version " + $versionType)
}

function deletesourcecode(){
  Invoke-Expression("rm .\\MVLauncher-win32-x64\\resources\\app")
}

function getappversion(){
  $packagejson = Get-Content -Raw -Path '.\package.json' | ConvertFrom-Json
  return $packagejson.version
}

function createreleasegit(){
  $version = getappversion
  $body = @{tag_name = $version
            target_commitish = "master"
            name = $version
            body = "Testing"
            draft = $false
            prerelease = $false}
  Invoke-RestMethod -uri https://api.github.com/repos/MVProduction/Launcher-Game/releases -body $body 
}

function pushreleasetogit(){
  createreleasegit
}

function main(){
    versionupgrade($typeofversionupgrade)
    packagebuild
    deletesourcecode
    
    if($updatetogitrelease){
      pushreleasetogit
    }

}

main