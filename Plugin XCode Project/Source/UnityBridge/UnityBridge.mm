#import "UnityBridge.h"

static UnityLogCallback logCallback = NULL;

void NSUnityLogCallback(UnityLogCallback callback) {
    logCallback = callback;
}

void NSUnityLog(const char* log){
    if(logCallback != NULL){
        logCallback(log);
    }
}