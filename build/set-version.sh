#!/usr/bin/env bash

if [[ -z "${CIRCLE_TAG}" ]]; then
  export PACKAGE_VERSION=$(build/semver get release $(git describe --tags))
  export PACKAGE_SUFFIX="ci-${CIRCLE_BUILD_NUM}"
else
  export PACKAGE_VERSION=$(build/semver get release ${CIRCLE_TAG})
  export PACKAGE_SUFFIX=""
fi

echo "PACKAGE_VERSION = ${PACKAGE_VERSION}"
echo "PACKAGE_SUFFIX = ${PACKAGE_SUFFIX}"
