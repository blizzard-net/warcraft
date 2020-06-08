#!/usr/bin/env bash

if [[ -z "${CIRCLE_TAG}" ]]; then
  # By default, get base version information from the most recent tag and add a "ci" suffix with the build number.
  export PACKAGE_VERSION_MAJOR=$(build/semver get release $(git describe --tags))
  export PACKAGE_VERSION="${PACKAGE_VERSION_MAJOR}-ci.${CIRCLE_BUILD_NUM}"
else
  # For a Git tag that has just been applied, remove the 'v' prefix.
  export PACKAGE_VERSION=${CIRCLE_TAG//v}
fi

echo "PACKAGE_VERSION = ${PACKAGE_VERSION}"
