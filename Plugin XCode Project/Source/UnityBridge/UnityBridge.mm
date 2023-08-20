#import "UnityBridge.h"

static UnityLogCallback logCallback = NULL;

void NSUnityLogCallback(UnityLogCallback callback) {
    logCallback = callback;
}

void NSUnityLog(NSString* log){
    if(logCallback != NULL){
        logCallback([log UTF8String]);
    }
}
