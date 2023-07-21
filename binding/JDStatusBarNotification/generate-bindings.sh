#!/usr/bin/env bash

set -euo pipefail

readonly script_dir="$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"

# sharpie xcode -sdks
readonly target_sdk="iphoneos15.5"
readonly build_dir="${script_dir}/build"
readonly output_dir="${build_dir}/Bindings"
readonly target_framework_dir="./JDStatusBarNotification.xcframework"  \

main() {

sharpie bind --output=JDStatusBarNotification \
--namespace=JDStatusBarNotification \
--sdk="iphoneos15.5" \
-scope ./native/JDStatusBarNotification/JDStatusBarNotification/Public/ ./native/JDStatusBarNotification/JDStatusBarNotification/Public/*.h \
-o binding
}

main
