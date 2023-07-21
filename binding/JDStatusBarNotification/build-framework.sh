#!/usr/bin/env bash

set -euo pipefail

readonly BUILD_DIR="build/framework"
readonly CONFIGURATION="Release"
readonly OUTPUT_DIR="${BUILD_DIR}/Frameworks/"

main() {


SCHEME_NAME="JDStatusBarNotification"
FRAMEWORK_NAME="JDStatusBarNotification"

SIMULATOR_ARCHIVE_PATH="${BUILD_DIR}/${CONFIGURATION}/${FRAMEWORK_NAME}-iphonesimulator.xcarchive"
SIMULATOR_X64_ARCHIVE_PATH="${BUILD_DIR}/${CONFIGURATION}/${FRAMEWORK_NAME}-iphonesimulatorx64.xcarchive"
DEVICE_ARCHIVE_PATH="${BUILD_DIR}/${CONFIGURATION}/${FRAMEWORK_NAME}-iphoneos.xcarchive"

# Simulator xcarchive (arm64)
xcodebuild archive \
  ONLY_ACTIVE_ARCH=NO \
  -scheme ${SCHEME_NAME} \
  -project "native/wrapper/framework/JDStatusBarNotification/JDStatusBarNotification.xcodeproj" \
  -archivePath ${SIMULATOR_ARCHIVE_PATH} \
  -sdk iphonesimulator \
  BUILD_LIBRARY_FOR_DISTRIBUTION=YES \
  SKIP_INSTALL=NO

# Device xcarchive (arm64)
xcodebuild archive \
  -scheme ${SCHEME_NAME} \
  -project "native/wrapper/framework/JDStatusBarNotification/JDStatusBarNotification.xcodeproj" \
  -archivePath ${DEVICE_ARCHIVE_PATH} \
  -sdk iphoneos \
  BUILD_LIBRARY_FOR_DISTRIBUTION=YES \
  SKIP_INSTALL=NO

# Clean-up any existing instance of this xcframework from the Products directory
rm -rf "${OUTPUT_DIR}${SCHEME_NAME}.xcframework"

# Create final xcframework
xcodebuild -create-xcframework \
    -framework ${DEVICE_ARCHIVE_PATH}/Products/Library/Frameworks/${FRAMEWORK_NAME}.framework \
    -framework ${SIMULATOR_ARCHIVE_PATH}/Products/Library/Frameworks/${FRAMEWORK_NAME}.framework \
     -output ${OUTPUT_DIR}/${FRAMEWORK_NAME}.xcframework

}

main
