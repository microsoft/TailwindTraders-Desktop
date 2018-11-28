# Resource group and location
$resourcegroup="tailwindtraders4"
$location="westus"

# Set an admin login and password for your database
$adminlogin="tailwindtraders"
$password="Tailwindtr4ders"

# The logical server name has to be unique in the system
$servername="$resourcegroup-server"
$dbname="$resourcegroup-db"

# Public ip
$ip = Invoke-RestMethod http://ipinfo.io/json | Select -exp ip

# Create a resource group
az group create --name $resourcegroup --location $location

az configure --defaults group=$resourcegroup
az configure --defaults location=$location

# Create a logical server in the resource group
az sql server create --name $servername --admin-user $adminlogin --admin-password $password

# Configure firewall rules for the server
az sql server firewall-rule create --server $servername -n AllowAzure --start-ip-address "0.0.0.0" --end-ip-address "0.0.0.0"
az sql server firewall-rule create --server $servername -n AllowRemoteIp --start-ip-address $ip --end-ip-address $ip

# Create a database in the server
az sql db create --server $servername --name $dbname

# Output connection-string
az sql db show-connection-string --server $servername --name $dbname --client ado.net

#az group delete --name tailwindtraders3