couponsRg=${TT_COUPONS_RG}
couponsRegion=${TT_COUPONS_REGION}
name=${TT_STORAGE_NAME}


function validate {
    valid=1

    if [[ "$couponsRg" == "" ]] 
    then
        echo "No resource group. Use -g to specify resource group."
        valid=0
    fi    
    if [[ "$couponsRegion" == "" ]] 
    then
        echo "No Azure region. Use -l to specify region"
        valid=0
    fi
    
    if [[ "$name" == "" ]] 
    then
        echo "No storage name specified: Please, set a storage name using -n"
        valid=0
    fi

    if (( valid == 0)) 
    then
        exit 1
    fi
}

while [ "$1" != "" ]; do
    case $1 in
        -g | --resource-group)          shift
                                        couponsRg=$1
                                        ;;
        -l | --location)                shift
                                        couponsRegion=$1
                                        ;;                                        
        -n | --name)                    shift
                                        name=$1
                                        ;;
       * )                              echo "Invalid param: $1"
                                        exit 1
    esac
    shift
done

validate

echo "------------------------------------------------------------"
echo "Creating resource groups $couponsRg if needed"
echo "------------------------------------------------------------"
az group create --name $couponsRg --location $couponsRegion

echo "------------------------------------------------------------"
echo "Deploying storage $name"
echo "------------------------------------------------------------"
az group deployment create -n $name -g $couponsRg --template-file storage-template.json --parameters storageAccountName=$name
az storage container create --name coupons-images --public-access blob --account-name $name
