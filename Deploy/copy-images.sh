couponsRg=${TT_COUPONS_RG}
couponsRegion=${TT_COUPONS_REGION}
name=${TT_STORAGE_NAME}
sourcepath="../Documents/Images"

function validate {
    valid=1

    if [[ "$couponsRg" == "" ]] 
    then
        echo "No resource group. Use -g to specify resource group."
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
        -n | --name)                    shift
                                        name=$1
                                        ;;
        -f | --source-path)             shift
                                        sourcepath=$1
                                        ;;
       * )                              echo "Invalid param: $1"
                                        exit 1
    esac
    shift
done

validate

constr=$(az storage account show-connection-string -g $couponsRg -n $name | jq ".connectionString" | tr -d '"')

echo "------------------------------------------------------------"
echo "Copying files from $sourcepath to storage $name"
echo "------------------------------------------------------------"
az storage blob upload-batch --source $sourcepath --connection-string "$constr" -d coupons-images
