exports.id = "src_autorest-as-a-service_ts";
exports.ids = ["src_autorest-as-a-service_ts"];
exports.modules = {

/***/ "./src/actions/check-autorest-update.ts":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.checkForAutoRestUpdate = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const semver_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/semver@5.7.1/node_modules/semver/semver.js");
const autorest_as_a_service_1 = __webpack_require__("./src/autorest-as-a-service.ts");
const constants_1 = __webpack_require__("./src/constants.ts");
/**
 * Check if there is any updates to the autorest package and display message to use if there is.
 * @param args Autorest cli args.
 */
const checkForAutoRestUpdate = async (args) => {
    if ((await autorest_as_a_service_1.networkEnabled) && !args["skip-upgrade-check"]) {
        try {
            const npmTag = args.preview ? "preview" : "latest";
            const newVersion = await isAutorestUpdateAvailable(npmTag);
            if (newVersion) {
                // eslint-disable-next-line no-console
                console.log((0, common_1.color)(`\n## There is a new version of AutoRest available (${newVersion.version}).\n > You can install the newer version with with \`npm install -g autorest@${npmTag}\`\n`));
            }
        }
        catch (e) {
            // no message then.
        }
    }
};
exports.checkForAutoRestUpdate = checkForAutoRestUpdate;
const isAutorestUpdateAvailable = async (npmTag) => {
    const pkg = await (await autorest_as_a_service_1.extensionManager).findPackage("autorest", npmTag);
    return (0, semver_1.gt)(pkg.version, constants_1.VERSION) ? pkg : undefined;
};


/***/ }),

/***/ "./src/actions/clear-temp-data.ts":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.clearTempData = void 0;
const os_1 = __webpack_require__("os");
const path_1 = __webpack_require__("path");
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const chalk_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/chalk@4.1.2/node_modules/chalk/source/index.js"));
/**
 * Clears out all autorest-temp folders from the temp folder.
 */
const clearTempData = async () => {
    const all = [];
    const tmp = (0, os_1.tmpdir)();
    for (const each of await (0, async_io_1.readdir)(tmp)) {
        if (each.startsWith("autorest")) {
            const name = (0, path_1.join)(tmp, each);
            if (await (0, async_io_1.isDirectory)(name)) {
                all.push((0, async_io_1.rmdir)(name));
            }
        }
    }
    if (all.length > 0) {
        // eslint-disable-next-line no-console
        console.log(chalk_1.default.grey(`Clearing ${all.length} autorest temp data folders...`));
    }
    await Promise.all(all);
};
exports.clearTempData = clearTempData;


/***/ }),

/***/ "./src/actions/index.ts":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("./src/actions/check-autorest-update.ts"), exports);
__exportStar(__webpack_require__("./src/actions/clear-temp-data.ts"), exports);


/***/ }),

/***/ "./src/autorest-as-a-service.ts":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.selectVersion = exports.ensureAutorestHome = exports.runCoreWithRequire = exports.runCoreOutOfProc = exports.resolveEntrypoint = exports.installedCores = exports.availableVersions = exports.networkEnabled = exports.newCorePackage = exports.oldCorePackage = exports.extensionManager = exports.rootFolder = void 0;
/* eslint-disable no-process-exit */
/* eslint-disable no-console */
/* eslint-disable @typescript-eslint/no-non-null-assertion */
const child_process_1 = __webpack_require__("child_process");
const dns_1 = __webpack_require__("dns");
const fs_1 = __webpack_require__("fs");
const os_1 = __webpack_require__("os");
const path_1 = __webpack_require__("path");
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const extension_1 = __webpack_require__("../../libs/extension/dist/src/index.js");
const tasks_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/tasks@3.0.255/node_modules/@azure-tools/tasks/dist/main.js");
const semver = __importStar(__webpack_require__("../../../common/temp/node_modules/.pnpm/semver@5.7.1/node_modules/semver/semver.js"));
const constants_1 = __webpack_require__("./src/constants.ts");
const utils_1 = __webpack_require__("./src/utils.ts");
const inWebpack = typeof __webpack_require__ === "function";
const nodeRequire = inWebpack ? require : __webpack_require__("./src sync recursive");
process.env["autorest.home"] = process.env["AUTOREST_HOME"] || process.env["autorest.home"] || (0, os_1.homedir)();
try {
    (0, fs_1.rmdirSync)((0, fs_1.mkdtempSync)((0, path_1.join)(process.env["autorest.home"], "temp")));
}
catch (_a) {
    // hmm. the home  directory isn't writable. let's fallback to $tmp
    process.env["autorest.home"] = (0, os_1.tmpdir)();
}
exports.rootFolder = (0, path_1.join)(process.env["autorest.home"], ".autorest");
const args = global.__args || {};
const pathToYarnCli = inWebpack ? `${__dirname}/yarn/cli.js` : undefined;
exports.extensionManager = extension_1.ExtensionManager.Create(exports.rootFolder, "yarn", pathToYarnCli);
exports.oldCorePackage = "@microsoft.azure/autorest-core";
exports.newCorePackage = "@autorest/core";
const basePkgVersion = semver.parse(constants_1.VERSION.indexOf("-") > -1 ? constants_1.VERSION.substring(0, constants_1.VERSION.indexOf("-")) : constants_1.VERSION);
/**
 * The version range of the core package required.
 * Require @autorest/core to have the same major version as autorest.
 */
const versionRange = `^${basePkgVersion.major}.0.0`;
exports.networkEnabled = new Promise((r, j) => {
    (0, dns_1.lookup)("8.8.8.8", 4, (err, address, family) => {
        r(err ? false : true);
    });
});
async function availableVersions() {
    if (await exports.networkEnabled) {
        try {
            const vers = (await (await exports.extensionManager).getPackageVersions(exports.newCorePackage)).sort((b, a) => semver.compare(a, b));
            const result = new Array();
            for (const ver of vers) {
                if (semver.satisfies(ver, versionRange)) {
                    result.push(ver);
                }
            }
            return result;
        }
        catch (e) {
            console.info(`No available versions of package ${exports.newCorePackage} found.`);
        }
    }
    else {
        console.info("Skipping getting available versions because network is not detected.");
    }
    return [];
}
exports.availableVersions = availableVersions;
async function installedCores() {
    const extensions = await (await exports.extensionManager).getInstalledExtensions();
    const result = extensions.length > 0
        ? extensions.filter((ext) => (ext.name === exports.newCorePackage || ext.name === exports.oldCorePackage) && semver.satisfies(ext.version, versionRange))
        : [];
    return result.sort((a, b) => semver.compare(b.version, a.version));
}
exports.installedCores = installedCores;
async function resolveEntrypoint(localPath, entrypoint) {
    try {
        // did they specify the package directory directly
        if (await (0, async_io_1.isDirectory)(localPath)) {
            // eslint-disable-next-line @typescript-eslint/no-var-requires
            const pkg = nodeRequire(`${localPath}/package.json`);
            if (pkg.name === "autorest") {
                // you've tried loading the bootstrapper not the core!
                console.error(`The location you have specified is not autorest-core, it's autorest bootstrapper: ${pkg.name}`);
                process.exit(1);
            }
            if (args.debug) {
                console.log(`Examining AutoRest core package: ${pkg.name}`);
            }
            if (pkg.name === exports.oldCorePackage || pkg.name === exports.newCorePackage) {
                if (args.debug) {
                    console.log("Looks like a core package.");
                }
                switch (entrypoint) {
                    case "main":
                    case "main.js":
                        entrypoint = pkg.main;
                        break;
                    case "language-service":
                    case "language-service.js":
                    case "autorest-language-service":
                        entrypoint = pkg.bin["autorest-language-service"];
                        break;
                    case "autorest":
                    case "autorest-core":
                    case "app.js":
                    case "app":
                        entrypoint = pkg.bin["autorest-core"] || pkg.bin["core"];
                        break;
                    case "module":
                        // special case: look for the main entrypoint
                        // but return the module folder
                        if (await (0, async_io_1.isFile)(`${localPath}/${pkg.main}`)) {
                            if (args.debug) {
                                console.log(`special case: '${localPath}/${pkg.main}' .`);
                            }
                            return localPath.replace(/\\/g, "/");
                        }
                }
                const path = `${localPath}/${entrypoint}`;
                if (await (0, async_io_1.isFile)(path)) {
                    if (args.debug) {
                        console.log(`Using Entrypoint: '${localPath}/${entrypoint}' .`);
                    }
                    return path.replace(/\\/g, "/");
                }
            }
        }
    }
    catch (_a) {
        // no worries
    }
    return undefined;
}
exports.resolveEntrypoint = resolveEntrypoint;
async function runCoreOutOfProc(localPath, entrypoint, config) {
    var _a;
    const env = {
        ...process.env,
    };
    if (config === null || config === void 0 ? void 0 : config.memory) {
        const maxMemory = (0, utils_1.parseMemory)(config.memory);
        if (maxMemory < 1024) {
            throw new Error("Cannot set memory to be less than 1GB(1024MB)");
        }
        env.NODE_OPTIONS = `${(_a = env.NODE_OPTIONS) !== null && _a !== void 0 ? _a : ""} --max_old_space_size=${maxMemory}`;
        console.log(`Setting memory to ${maxMemory}mb for @autorest/core`);
    }
    try {
        const ep = await resolveEntrypoint(localPath, entrypoint);
        if (ep) {
            // Creates the nodejs command to load the target core
            // - copies the argv parameters
            // - loads the js file with coloring (core expects a global function called 'color' )
            //   This is needed currently for @autorest/core version older than 3.6.0(After autorest-core include the color itself.)
            // - loads the actual entrypoint that we expect is there.
            const cmd = `
        process.argv = ${JSON.stringify(process.argv)};
        const { color } = require('${__dirname}/exports');
        global.color = color;
        require('${ep}')
      `
                .replace(/"/g, "'")
                .replace(/(\\(?![']))+/g, "/");
            const p = (0, child_process_1.spawn)(process.execPath, ["-e", cmd], { stdio: ["inherit", "inherit", "inherit"], env });
            p.on("close", (code, signal) => {
                process.exit(code !== null && code !== void 0 ? code : -1);
            });
            // set up a promise to wait for the event to fire
            await (0, tasks_1.When)(p, "exit", "close");
            process.exit(0);
        }
    }
    catch (E) {
        console.log(E);
    }
    return null;
}
exports.runCoreOutOfProc = runCoreOutOfProc;
async function runCoreWithRequire(localPath, entrypoint, config) {
    if (config === null || config === void 0 ? void 0 : config.memory) {
        console.warn("Cannot use --memory flag when running in debugging mode. Use NODE_OPTIONS env variable with flag `--max_old_space_size` to set the node max memory.");
    }
    try {
        const ep = await resolveEntrypoint(localPath, entrypoint);
        if (ep) {
            return nodeRequire(ep);
        }
    }
    catch (E) {
        console.log(E);
    }
    return null;
}
exports.runCoreWithRequire = runCoreWithRequire;
async function ensureAutorestHome() {
    await (0, async_io_1.mkdir)(exports.rootFolder);
}
exports.ensureAutorestHome = ensureAutorestHome;
async function selectVersion(logger, requestedVersion, force, minimumVersion) {
    const installedVersions = await installedCores();
    let currentVersion = installedVersions[0] || null;
    // the consumer can say I want the latest-installed, but at least XXX.XXX
    if (minimumVersion && currentVersion && !semver.satisfies(currentVersion.version, minimumVersion)) {
        currentVersion = null;
    }
    if (currentVersion) {
        logger.debug(`The most recent installed version is ${currentVersion.version}`);
        if (requestedVersion === "latest-installed" || (requestedVersion === "latest" && false == (await exports.networkEnabled))) {
            logger.debug(`requesting current version '${currentVersion.version}'`);
            requestedVersion = currentVersion.version;
        }
    }
    else {
        logger.debug(`No ${exports.newCorePackage} (or ${exports.oldCorePackage}) is installed.`);
    }
    let selectedVersion = null;
    // take the highest version that satisfies the version range.
    for (const each of installedVersions.sort((a, b) => semver.compare(a === null || a === void 0 ? void 0 : a.version, b === null || b === void 0 ? void 0 : b.version))) {
        if (semver.satisfies(each.version, requestedVersion)) {
            selectedVersion = each;
        }
    }
    // is the requested version installed?
    if (!selectedVersion || force) {
        if (!force) {
            logger.debug(`${requestedVersion} was not satisfied directly by a previous installation.`);
        }
        // if it's not a file, and the network isn't available, we can't continue.
        if (!(await (0, async_io_1.isFile)(requestedVersion)) && !(await exports.networkEnabled)) {
            // no network enabled.
            throw new tasks_1.Exception(`Network access is not available, requested version '${requestedVersion}' is not installed. `);
        }
        // after this point, latest-installed must mean latest.
        if (requestedVersion === "latest-installed") {
            requestedVersion = "latest";
        }
        // if they have requested 'latest' -- they really mean latest with same major version number
        if (requestedVersion === "latest") {
            requestedVersion = versionRange;
        }
        let corePackageName = exports.newCorePackage;
        let pkg = undefined;
        try {
            // try the package
            pkg = await (await exports.extensionManager).findPackage(exports.newCorePackage, requestedVersion);
        }
        catch (_a) {
            // try a prerelease version from github.
            try {
                const rv = requestedVersion.replace(/^[~|^]/g, "");
                pkg = await (await exports.extensionManager).findPackage("core", `https://github.com/Azure/autorest/releases/download/autorest-core-${rv}/autorest-core-${rv}.tgz`);
            }
            catch (_b) {
                // fallback to old package name
                try {
                    pkg = await (await exports.extensionManager).findPackage(exports.oldCorePackage, requestedVersion);
                }
                catch (_c) {
                    // no package found!
                }
            }
            if (!pkg) {
                throw new tasks_1.Exception(`Unable to find a valid AutoRest core package '${exports.newCorePackage}' @ '${requestedVersion}'.`);
            }
            corePackageName = exports.oldCorePackage;
        }
        if (pkg) {
            if (args.debug) {
                console.log(`Selected package: ${pkg.resolvedInfo.rawSpec} => ${pkg.name}@${pkg.version}`);
            }
        }
        // pkg.version == the actual version
        // check if it's installed already.
        selectedVersion = await (await exports.extensionManager).getInstalledExtension(corePackageName, pkg.version);
        if (!selectedVersion || force) {
            // this will throw if there is an issue with installing the extension.
            if (args.debug) {
                console.log(`**Installing package** ${corePackageName}@${pkg.version}\n[This will take a few moments...]`);
            }
            // @autorest/core install too fast and this doesn't look good right now as Yarn doesn't give info fast enough.
            // If we migrate to yarn v2 with the api we might be able to get more info and reenable that
            const progress = logger.startProgress("installing core...");
            selectedVersion = await (await exports.extensionManager).installPackage(pkg, force, 5 * 60 * 1000, (status) => {
                progress.update({ ...status });
            });
            progress.stop();
            if (args.debug) {
                console.log(`Extension location: ${selectedVersion.packageJsonPath}`);
            }
        }
        else {
            if (args.debug) {
                console.log(`AutoRest Core ${pkg.version} is available at ${selectedVersion.modulePath}`);
            }
        }
    }
    return selectedVersion;
}
exports.selectVersion = selectVersion;


/***/ }),

/***/ "./src/constants.ts":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.VERSION = exports.AppRoot = void 0;
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
const fs_1 = __webpack_require__("fs");
const path = __importStar(__webpack_require__("path"));
const resolveAppRoot = () => {
    let current = path.resolve(__dirname);
    while (!(0, fs_1.existsSync)(path.join(current, "package.json"))) {
        current = path.dirname(current);
    }
    return current;
};
/**
 * Root of autorest core(i.e core folder)
 */
exports.AppRoot = resolveAppRoot();
/**
 * Version of this package(autorest).
 */
exports.VERSION = __webpack_require__("./package.json").version;


/***/ }),

/***/ "./src/utils.ts":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.parseMemory = exports.resolveCoreVersion = exports.resolvePathForLocalVersion = exports.loadConfig = exports.getRequestedCoreVersion = void 0;
const path_1 = __webpack_require__("path");
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const configuration_1 = __webpack_require__("../../libs/configuration/dist/index.js");
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const untildify_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/untildify@4.0.0/node_modules/untildify/index.js"));
const actions_1 = __webpack_require__("./src/actions/index.ts");
const autorest_as_a_service_1 = __webpack_require__("./src/autorest-as-a-service.ts");
const constants_1 = __webpack_require__("./src/constants.ts");
const inWebpack = typeof __webpack_require__ === "function";
// eslint-disable-next-line @typescript-eslint/no-non-null-assertion
const nodeRequire = inWebpack ? require : __webpack_require__("./src sync recursive");
const defaultConfigUri = inWebpack
    ? (0, uri_1.resolveUri)((0, uri_1.createFolderUri)(constants_1.AppRoot), `dist/resources/default-configuration.md`)
    : (0, uri_1.createFileOrFolderUri)(nodeRequire.resolve("@autorest/configuration/resources/default-configuration.md"));
/**
 * Return the version requested of the core extension.
 * @param args ClI args.
 * @returns npm version/tag.
 */
const getRequestedCoreVersion = (args) => {
    var _a;
    return (_a = args.version) !== null && _a !== void 0 ? _a : (args.latest ? "latest" : args.preview ? "preview" : undefined);
};
exports.getRequestedCoreVersion = getRequestedCoreVersion;
const cwd = process.cwd();
/**
 * Tries to load the configuration of autorest.
 * @param args CLI args.
 */
async function loadConfig(sink, args) {
    const configFileOrFolder = (0, uri_1.resolveUri)((0, uri_1.createFolderUri)(cwd), args.configFileOrFolder || ".");
    const enableLogging = args["debug-cli-config-loading"];
    const logger = new common_1.AutorestSyncLogger({
        sinks: enableLogging ? [sink] : [],
    });
    const loader = new configuration_1.ConfigurationLoader(logger, defaultConfigUri, configFileOrFolder, {
    // extensionManager: await extensionManager,
    });
    try {
        const { config } = await loader.load([args], true);
        return config;
    }
    catch (e) {
        // eslint-disable-next-line no-console
        logger.log({ level: "warning", message: "Error occured while loading configuration." });
        return undefined;
    }
}
exports.loadConfig = loadConfig;
/**
 * Check if the requested version points to a local dev version of @autorest/core or there is one globally available.
 * @param requestedVersion Core version
 * @returns Path to the local version or undefined if there isn't one.
 */
async function resolvePathForLocalVersion(requestedVersion) {
    try {
        const localVersion = requestedVersion
            ? (0, path_1.resolve)((0, untildify_1.default)(requestedVersion))
            : (0, path_1.dirname)(nodeRequire.resolve("@autorest/core/package.json"));
        return (await (0, async_io_1.isFile)((0, path_1.join)(localVersion, "package.json"))) ? localVersion : undefined;
    }
    catch (e) {
        // fallback to old-core name
        try {
            // eslint-disable-next-line node/no-missing-require
            return (0, path_1.dirname)(nodeRequire.resolve("@microsoft.azure/autorest-core/package.json"));
        }
        catch (_a) {
            // no dice
        }
    }
    return undefined;
}
exports.resolvePathForLocalVersion = resolvePathForLocalVersion;
async function resolveCoreVersion(logger, config = {}) {
    var _a;
    const requestedVersion = (_a = (0, exports.getRequestedCoreVersion)(config)) !== null && _a !== void 0 ? _a : "latest-installed";
    const localVersion = await resolvePathForLocalVersion(config.version ? requestedVersion : null);
    if (localVersion) {
        return localVersion;
    }
    // failing that, we'll continue on and see if NPM can do something with the version.
    if (config.debug) {
        // eslint-disable-next-line no-console
        logger.debug(`Network Enabled: ${await autorest_as_a_service_1.networkEnabled}`);
    }
    // wait for the bootstrapper check to finish.
    await (0, actions_1.checkForAutoRestUpdate)(config);
    // logic to resolve and optionally install a autorest core package.
    // will throw if it's not doable.
    const selectedVersion = await (0, autorest_as_a_service_1.selectVersion)(logger, requestedVersion, config.debugger);
    return selectedVersion.modulePath;
}
exports.resolveCoreVersion = resolveCoreVersion;
/**
 *
 * @param maxMemory Max memory string(2048m, 2g)
 * @returns Max memory that will be allowed for the cnode process in MB
 */
function parseMemory(maxMemory) {
    const regex = /^(\d+)([mg])$/i;
    const match = regex.exec(maxMemory.trim());
    if (!match) {
        throw new Error(`Couldn't parse memory setting ${maxMemory}. Please provide in this format: 2048m, 2g, etc. Supported units: m,g`);
    }
    const number = Number(match[1]);
    const unit = match[2];
    return number * getUnitMultiplier(unit);
}
exports.parseMemory = parseMemory;
function getUnitMultiplier(unit) {
    switch (unit) {
        case "m":
            return 1; // = 1024 * 1024;
        case "g":
            return 1024; // 1024 * 1024 * 1024;
        default:
            throw new Error(`Unexpected unit ${unit}.`);
    }
}


/***/ }),

/***/ "./package.json":
/***/ ((module) => {

"use strict";
module.exports = {"version":"3.5.1"};

/***/ }),

/***/ "./src sync recursive":
/***/ ((module) => {

function webpackEmptyContext(req) {
	var e = new Error("Cannot find module '" + req + "'");
	e.code = 'MODULE_NOT_FOUND';
	throw e;
}
webpackEmptyContext.keys = () => ([]);
webpackEmptyContext.resolve = webpackEmptyContext;
webpackEmptyContext.id = "./src sync recursive";
module.exports = webpackEmptyContext;

/***/ }),

/***/ "../../libs/codegen/dist/apiversion/apiversion.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.maximum = exports.minimum = exports.highest = exports.lowest = exports.gt = exports.lt = exports.toSemver = void 0;
const semver = __importStar(__webpack_require__("../../../common/temp/node_modules/.pnpm/semver@5.7.1/node_modules/semver/semver.js"));
/*
 Handling:

 yyyy-mm                      n(yyyy).n(mm).0
 yyyy-mm-preview              n(yyyy).n(mm).0-preview
 yyyy-mm-dd                   n(yyyy).n(mm).n(dd)
 yyyy-mm-dd-preview           n(yyyy).n(mm).n(dd)-preview
 yyyy-mm-dd.x1.x2             (miliseconds since 1970-01-01).x1.x2
 x1.x2.x3.x4                  x1.x2.x3
 x.x                          x.x.0
 vx.x                         x.x.0
 vx.x-preview                 x.x.0-preview
*/
function toSemver(apiversion) {
    // let result = '';
    // strip off leading "v" or "=" character
    apiversion = apiversion.replace(/^v|^=/gi, "");
    // eslint-disable-next-line no-useless-escape
    const versionedDateRegex = new RegExp(/(^\d{4}\-\d{2}\-\d{2})(\.\d+\.\d+$)/gi);
    if (apiversion.match(versionedDateRegex)) {
        // convert yyyy-mm-dd.x1.x2      --->     (miliseconds since 1970-01-01).x1.x2
        const date = apiversion.replace(versionedDateRegex, "$1");
        const miliseconds = new Date(date).getTime();
        const lastNumbers = apiversion.replace(versionedDateRegex, "$2");
        return `${miliseconds}${lastNumbers}`;
    }
    const [whole, major, minor, revision, tag] = /^(\d+)-(\d+)(?:-(\d+))?(.*)/.exec(apiversion) ||
        /(\d*)\.(\d*)\.(\d*)(.*)/.exec(apiversion) ||
        /(\d*)\.(\d*)()(.*)/.exec(apiversion) ||
        /(\d*)()()(.*)/.exec(apiversion) ||
        [];
    return `${Number.parseInt(major || "0") || 0}.${Number.parseInt(minor || "0") || 0}.${Number.parseInt(revision || "0") || 0}${(tag === null || tag === void 0 ? void 0 : tag.startsWith("-")) ? tag : ""}`;
}
exports.toSemver = toSemver;
function lt(apiVersion1, apiVersion2) {
    const v1 = toSemver(apiVersion1);
    const v2 = toSemver(apiVersion2);
    return semver.lt(v1, v2);
}
exports.lt = lt;
function gt(apiVersion1, apiVersion2) {
    const v1 = toSemver(apiVersion1);
    const v2 = toSemver(apiVersion2);
    return semver.gt(v1, v2);
}
exports.gt = gt;
function lowest(apiVersion1, apiVersion2) {
    return lt(apiVersion1, apiVersion2) ? apiVersion1 : apiVersion2;
}
exports.lowest = lowest;
function highest(apiVersion1, apiVersion2) {
    return gt(apiVersion1, apiVersion2) ? apiVersion1 : apiVersion2;
}
exports.highest = highest;
function minimum(apiversions) {
    if (apiversions.length === 0) {
        return "";
    }
    let result = apiversions[0];
    for (const each of apiversions) {
        result = lowest(result, each);
    }
    return result;
}
exports.minimum = minimum;
function maximum(apiversions) {
    if (apiversions.length === 0) {
        return "";
    }
    let result = apiversions[0];
    for (const each of apiversions) {
        result = highest(result, each);
    }
    return result;
}
exports.maximum = maximum;
//# sourceMappingURL=apiversion.js.map

/***/ }),

/***/ "../../libs/codegen/dist/exec.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.execute = exports.resolveFullPath = exports.cmdlineToArray = void 0;
const child_process_1 = __webpack_require__("child_process");
const path = __importStar(__webpack_require__("path"));
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
function cmdlineToArray(text, result = [], matcher = /[^\s"]+|"([^"]*)"/gi, count = 0) {
    text = text.replace(/\\"/g, "\ufffe");
    const match = matcher.exec(text);
    return match
        ? cmdlineToArray(text, result, matcher, result.push(match[1] ? match[1].replace(/\ufffe/g, '\\"') : match[0].replace(/\ufffe/g, '\\"')))
        : result;
}
exports.cmdlineToArray = cmdlineToArray;
function getPathVariableName() {
    // windows calls it's path 'Path' usually, but this is not guaranteed.
    if (process.platform === "win32") {
        let PATH = "Path";
        Object.keys(process.env).forEach(function (e) {
            if (e.match(/^PATH$/i)) {
                PATH = e;
            }
        });
        return PATH;
    }
    return "PATH";
}
async function realPathWithExtension(command) {
    const pathExt = (process.env.pathext || ".EXE").split(";");
    for (const each of pathExt) {
        const filename = `${command}${each}`;
        if (await (0, async_io_1.isFile)(filename)) {
            return filename;
        }
    }
    return undefined;
}
async function getFullPath(command, recursive = false, searchPath) {
    command = command.replace(/"/g, "");
    const ext = path.extname(command);
    if (path.isAbsolute(command)) {
        // if the file has an extension, or we're not on win32, and this is an actual file, use it.
        if (ext || process.platform !== "win32") {
            if (await (0, async_io_1.isFile)(command)) {
                return command;
            }
        }
        // if we're on windows, look for a file with an acceptable extension.
        if (process.platform === "win32") {
            // try all the PATHEXT extensions to see if it is a recognized program
            const cmd = await realPathWithExtension(command);
            if (cmd) {
                return cmd;
            }
        }
        return undefined;
    }
    if (searchPath) {
        for (const folder of searchPath) {
            let fullPath = await getFullPath(path.resolve(folder, command));
            if (fullPath) {
                return fullPath;
            }
            if (recursive) {
                try {
                    for (const entry of await (0, async_io_1.readdir)(folder)) {
                        const folderPath = path.resolve(folder, entry);
                        if (await (0, async_io_1.isDirectory)(folderPath)) {
                            fullPath =
                                (await getFullPath(path.join(folderPath, command))) || (await getFullPath(command, true, [folderPath]));
                            if (fullPath) {
                                return fullPath;
                            }
                        }
                    }
                }
                catch (_a) {
                    // ignore failures
                }
            }
        }
    }
    return undefined;
}
function quoteIfNecessary(text) {
    if (text && text.indexOf(" ") > -1 && text.charAt(0) !== '"') {
        return `"${text}"`;
    }
    return text;
}
function getSearchPath() {
    return (process.env[getPathVariableName()] || "").split(path.delimiter);
}
async function resolveFullPath(command, alternateRecursiveFolders) {
    let fullCommandPath = await getFullPath(command, false, getSearchPath());
    if (!fullCommandPath) {
        // fallback to searching the subfolders we're given.
        if (alternateRecursiveFolders) {
            fullCommandPath = await getFullPath(command, true, alternateRecursiveFolders);
        }
    }
    return fullCommandPath;
}
exports.resolveFullPath = resolveFullPath;
async function execute(cwd, command, ...parameters) {
    const fullCommandPath = await resolveFullPath(command);
    if (!fullCommandPath) {
        throw new Error(`Unknown command ${command}`);
    }
    // quote parameters if necessary?
    for (let i = 0; i < parameters.length; i++) {
        // parameters[i] = quoteIfNecessary(parameters[i]);
    }
    return new Promise((r, j) => {
        if (process.platform === "win32" && fullCommandPath.indexOf(" ") > -1 && !/.exe$/gi.exec(fullCommandPath)) {
            const pathVar = getPathVariableName();
            // preserve the current path
            const originalPath = process.env[pathVar];
            try {
                // insert the dir into the path
                process.env[pathVar] = `${path.dirname(fullCommandPath)}${path.delimiter}${originalPath}`;
                // call spawn and return
                (0, child_process_1.spawn)(path.basename(fullCommandPath), parameters, { env: process.env, cwd, stdio: "inherit" }).on("close", (c, s) => {
                    if (c) {
                        j("Command Failed");
                    }
                    r();
                });
                return;
            }
            finally {
                // regardless, restore the original path on the way out!
                process.env[pathVar] = originalPath;
            }
        }
        (0, child_process_1.spawn)(fullCommandPath, parameters, { env: process.env, cwd, stdio: "inherit" }).on("close", (c, s) => {
            if (c) {
                j("Command Failed");
            }
            r();
        });
        return;
    });
}
exports.execute = execute;
//# sourceMappingURL=exec.js.map

/***/ }),

/***/ "../../libs/codegen/dist/file-generator.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.TextWithRegions = exports.Text = exports.isTextEdit = exports.isText = void 0;
const initializer_1 = __webpack_require__("../../libs/codegen/dist/initializer.js");
const text_manipulation_1 = __webpack_require__("../../libs/codegen/dist/text-manipulation.js");
function isText(object) {
    return object.text ? true : false;
}
exports.isText = isText;
function isTextEdit(object) {
    return object.edit ? true : false;
}
exports.isTextEdit = isTextEdit;
class Text extends initializer_1.Initializer {
    constructor(content, objectIntializer) {
        super();
        this.content = new Array();
        this.toString = () => {
            return this.text;
        };
        if (content) {
            this.add(content);
        }
        this.apply(objectIntializer);
    }
    get count() {
        return this.content.length;
    }
    add(text) {
        if (typeof text === "string") {
            this.content.push(text);
            return this;
        }
        if (text instanceof Text) {
            this.content.push(text);
            return this;
        }
        if (isText(text) || isTextEdit(text)) {
            this.content.push(text);
            return this;
        }
        if (typeof text === "function") {
            return this.add(text());
        }
        for (const each of text) {
            this.add(each);
        }
        return this;
    }
    get text() {
        let output = "";
        for (const each of this.content) {
            if (typeof each === "string") {
                output = output + text_manipulation_1.EOL + each;
                continue;
            }
            if (isTextEdit(each)) {
                output = each.edit(output) + text_manipulation_1.EOL;
                continue;
            }
            output = output + text_manipulation_1.EOL + each.text;
        }
        return output;
    }
    trim() {
        this.add({ edit: (s) => s.trim() });
    }
}
exports.Text = Text;
class TextWithRegions extends Text {
    constructor(content, objectIntializer, prefix = "#", postfix = "") {
        super(content);
        this.apply(objectIntializer);
        this.prefix = prefix;
        this.postfix = postfix;
    }
    removeRegion(region) {
        this.add({ edit: (s) => (0, text_manipulation_1.setRegion)(s, region, "", undefined, this.prefix, this.postfix) });
    }
    setRegion(region, content, prepend = true) {
        this.add({ edit: (s) => (0, text_manipulation_1.setRegion)(s, region, content, prepend, this.prefix, this.postfix) });
    }
    has(name) {
        for (const each of (0, text_manipulation_1.getRegions)(this.text, this.prefix, this.postfix)) {
            if (each.name === name) {
                return true;
            }
        }
        return false;
    }
    append(name, content) {
        this.add({ edit: (s) => (0, text_manipulation_1.setRegion)(s, name, content, false, this.prefix, this.postfix) });
    }
    prepend(name, content) {
        this.add({ edit: (s) => (0, text_manipulation_1.setRegion)(s, name, content, true, this.prefix, this.postfix) });
    }
    get regions() {
        if (!this.text.trim()) {
            return [];
        }
        return [...(0, text_manipulation_1.getRegions)(this.text, this.prefix, this.postfix)];
    }
}
exports.TextWithRegions = TextWithRegions;
//# sourceMappingURL=file-generator.js.map

/***/ }),

/***/ "../../libs/codegen/dist/formatter/formatter.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.Style = void 0;
const text_manipulation_1 = __webpack_require__("../../libs/codegen/dist/text-manipulation.js");
function capitalize(s) {
    return s ? `${s.charAt(0).toUpperCase()}${s.substr(1)}` : s;
}
function uncapitalize(s) {
    return s ? `${s.charAt(0).toLowerCase()}${s.substr(1)}` : s;
}
function IsFullyUpperCase(identifier, maxUppercasePreserve) {
    const len = identifier.length;
    if (len > 1) {
        if (len <= maxUppercasePreserve && identifier === identifier.toUpperCase()) {
            return true;
        }
        if (len <= maxUppercasePreserve + 1 && identifier.endsWith("s")) {
            const i = identifier.substring(0, len - 1);
            if (i.toUpperCase() === i) {
                return true;
            }
        }
    }
    return false;
}
function deconstruct(identifier, maxUppercasePreserve) {
    if (Array.isArray(identifier)) {
        return [...identifier.flatMap((each) => deconstruct(each, maxUppercasePreserve))];
    }
    return `${identifier}`
        .replace(/([a-z]+)([A-Z])/g, "$1 $2") // Add a space in between camelCase words(e.g. fooBar => foo Bar)
        .replace(/(\d+)/g, " $1 ") // Adds a space after numbers(e.g. foo123 => foo123 bar)
        .replace(/\b([A-Z]+)([A-Z])s([^a-z])(.*)/g, "$1$2?? $3$4") // Add a space after a plural uppper cased word(e.g. MBsFoo => MBs Foo)
        .replace(/\b([A-Z]+)([A-Z])([a-z]+)/g, "$1 $2$3") // Add a space between an upper case word(2 char+) and the last captial case.(e.g. SQLConnection -> SQL Connection)
        .replace(/??/g, "s")
        .trim()
        .split(/[\W|_]+/)
        .map((each) => (IsFullyUpperCase(each, maxUppercasePreserve) ? each : each.toLowerCase()));
}
function wrap(prefix, postfix, style, maxUppercasePreserve) {
    if (postfix || prefix) {
        return (i, r, o) => typeof i === "string" && typeof o === "object"
            ? o[i.toLowerCase()] || `${prefix}${style(i, r, o, maxUppercasePreserve)}${postfix}`
            : `${prefix}${style(i, r, o, maxUppercasePreserve)}${postfix}`;
    }
    return (i, r, o) => style(i, r, o, maxUppercasePreserve);
}
function applyFormat(normalizedContent, overrides = {}, separator = "", formatter = (s, i) => s) {
    return normalizedContent
        .map((each, index) => overrides[each.toLowerCase()] || formatter(each, index))
        .join(separator);
}
function normalize(identifier, removeDuplicates = true, overrides = {}, maxUppercasePreserve = 0) {
    if (!identifier || identifier.length === 0) {
        return [""];
    }
    return typeof identifier === "string"
        ? normalize((0, text_manipulation_1.fixLeadingNumber)(deconstruct(identifier, maxUppercasePreserve)), removeDuplicates, overrides, maxUppercasePreserve)
        : removeDuplicates
            ? (0, text_manipulation_1.removeSequentialDuplicates)(identifier)
            : identifier;
}
class Style {
    static select(style, fallback, maxUppercasePreserve) {
        if (style) {
            const styles = /^([a-zA-Z0-9_]*?\+?)([a-zA-Z]+)(\+?[a-zA-Z0-9_]*)$/g.exec(style.replace(/\s*/g, ""));
            if (styles) {
                const prefix = styles[1] ? styles[1].substring(0, styles[1].length - 1) : "";
                const postfix = styles[3] ? styles[3].substring(1) : "";
                switch (styles[2]) {
                    case "camelcase":
                    case "camel":
                        return wrap(prefix, postfix, Style.camel, maxUppercasePreserve);
                    case "pascalcase":
                    case "pascal":
                        return wrap(prefix, postfix, Style.pascal, maxUppercasePreserve);
                    case "snakecase":
                    case "snake":
                        return wrap(prefix, postfix, Style.snake, maxUppercasePreserve);
                    case "uppercase":
                    case "upper":
                        return wrap(prefix, postfix, Style.upper, maxUppercasePreserve);
                    case "kebabcase":
                    case "kebab":
                        return wrap(prefix, postfix, Style.kebab, maxUppercasePreserve);
                    case "spacecase":
                    case "space":
                        return wrap(prefix, postfix, Style.space, maxUppercasePreserve);
                }
            }
        }
        return wrap("", "", fallback, maxUppercasePreserve);
    }
    static kebab(identifier, removeDuplicates = true, overrides = {}, maxUppercasePreserve = 0) {
        return (overrides[identifier] ||
            applyFormat(normalize(identifier, removeDuplicates, overrides, maxUppercasePreserve), overrides, "-").replace(/([^\d])-(\d+)/g, "$1$2"));
    }
    static space(identifier, removeDuplicates = true, overrides = {}, maxUppercasePreserve = 0) {
        return (overrides[identifier] ||
            applyFormat(normalize(identifier, removeDuplicates, overrides, maxUppercasePreserve), overrides, " ").replace(/([^\d]) (\d+)/g, "$1$2"));
    }
    static snake(identifier, removeDuplicates = true, overrides = {}, maxUppercasePreserve = 0) {
        return (overrides[identifier] ||
            applyFormat(normalize(identifier, removeDuplicates, overrides, maxUppercasePreserve), overrides, "_").replace(/([^\d])_(\d+)/g, "$1$2"));
    }
    static upper(identifier, removeDuplicates = true, overrides = {}, maxUppercasePreserve = 0) {
        return (overrides[identifier] ||
            applyFormat(normalize(identifier, removeDuplicates, overrides, maxUppercasePreserve), overrides, "_", (each) => each.toUpperCase()).replace(/([^\d])_(\d+)/g, "$1$2"));
    }
    static pascal(identifier, removeDuplicates = true, overrides = {}, maxUppercasePreserve = 0) {
        return (overrides[identifier] ||
            applyFormat(normalize(identifier, removeDuplicates, overrides, maxUppercasePreserve), overrides, "", (each) => capitalize(each)));
    }
    static camel(identifier, removeDuplicates = true, overrides = {}, maxUppercasePreserve = 0) {
        return (overrides[identifier] ||
            applyFormat(normalize(identifier, removeDuplicates, overrides, maxUppercasePreserve), overrides, "", (each, index) => index ? capitalize(each) : IsFullyUpperCase(each, maxUppercasePreserve) ? each : uncapitalize(each)));
    }
}
exports.Style = Style;
//# sourceMappingURL=formatter.js.map

/***/ }),

/***/ "../../libs/codegen/dist/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/codegen/dist/exec.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/file-generator.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/initializer.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/intersect.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/pluralization.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/text-manipulation.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/utility.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/yaml.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/apiversion/apiversion.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/safe-eval.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/source-track.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/media-types.js"), exports);
__exportStar(__webpack_require__("../../libs/codegen/dist/formatter/formatter.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/codegen/dist/initializer.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.Initializer = void 0;
const empty = new Set();
function applyTo(source, target, exclusions, cache = new Set()) {
    if (cache.has(source)) {
        throw new Error("Circular refrenced models are not permitted in apply() initializers.");
    }
    for (const i of Object.keys(source !== null && source !== void 0 ? source : {})) {
        if (exclusions.has(i)) {
            continue;
        }
        switch (typeof source[i]) {
            case "object":
                // merge objects
                if (source[i] != null && source[i] != undefined && typeof target[i] === "object") {
                    cache.add(source);
                    try {
                        applyTo(source[i], target[i], exclusions, cache);
                    }
                    catch (E) {
                        // eslint-disable-next-line no-console
                        console.error(`  in property: ${i} `);
                        throw E;
                    }
                    cache.delete(source);
                    continue;
                }
                // otherwise, just use that object.
                target[i] = source[i];
                continue;
            /* bad idea? :
      
            this recursively cloned the contents of the intializer
            but this has the effect of breaking referencs where I wanted
            them.
      
            // copy toarray
            if (Array.isArray(source[i])) {
              cache.add(source);
              applyTo(source[i], target[i] = [], cache);
              cache.delete(source);
              continue;
            }
      
            // otherwise, copy into an empty object
            cache.add(source);
            applyTo(source[i], target[i] = {}, cache);
            cache.delete(source);
            continue;
          */
            default:
                // everything else just replace.
                target[i] = source[i];
                continue;
        }
    }
}
/** inheriting from Initializer adds an apply<T> method to the class, allowing you to accept an object initalizer, and applying it to the class in the constructor. */
class Initializer {
    apply(...initializer) {
        for (const each of initializer) {
            applyTo(each, this, empty);
        }
    }
    applyWithExclusions(exclusions, ...initializer) {
        const filter = new Set(exclusions);
        for (const each of initializer) {
            applyTo(each, this, filter);
        }
    }
    applyTo($this, ...initializer) {
        for (const each of initializer) {
            applyTo(each, $this, empty);
        }
    }
}
exports.Initializer = Initializer;
//# sourceMappingURL=initializer.js.map

/***/ }),

/***/ "../../libs/codegen/dist/intersect.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.intersect = void 0;
/**
 * Creates an intersection object from two source objects.
 *
 * Typescript nicely supports defining intersection types (ie, Foo & Bar )
 * But if you have two seperate *instances*, and you want to use them as the implementation
 * of that intersection, the language doesn't solve that for you.
 *
 * This function creates a strongly typed proxy type around the two objects,
 * and returns members for the intersection of them.
 *
 * This works well for properties and member functions the same.
 *
 * Members in the primary object will take precedence over members in the secondary object if names conflict.
 *
 * This can also be used to "add" arbitrary members to an existing type (without mutating the original object)
 *
 * @example
 * const combined = intersect( new Foo(), { test: () => { console.log('testing'); } });
 * combined.test(); // writes out 'testing' to console
 *
 * @param primary primary object - members from this will have precedence.
 * @param secondary secondary object - members from this will be used if primary does not have a member
 */
function intersect(primary, secondary) {
    return new Proxy({ primary, secondary }, {
        // member get proxy handler
        get(target, property, receiver) {
            // check for properties on the objects first
            const propertyName = property.toString();
            if (Object.getOwnPropertyNames(target.primary).indexOf(propertyName) > -1) {
                return target.primary[property];
            }
            if (Object.getOwnPropertyNames(target.secondary).indexOf(propertyName) > -1) {
                return target.secondary[property];
            }
            // try binding member function
            if (typeof target.primary[property] === "function") {
                return target.primary[property].bind(primary);
            }
            if (typeof target.secondary[property] === "function") {
                return target.secondary[property].bind(secondary);
            }
            return target.primary[property] || target.secondary[property];
        },
        // member set proxy handler
        set(target, property, value) {
            const propertyName = property.toString();
            if (Object.getOwnPropertyNames(target.primary).indexOf(propertyName) > -1) {
                return (target.primary[property] = value);
            }
            if (Object.getOwnPropertyNames(target.secondary).indexOf(propertyName) > -1) {
                return (target.secondary[property] = value);
            }
            return undefined;
        },
    });
}
exports.intersect = intersect;
//# sourceMappingURL=intersect.js.map

/***/ }),

/***/ "../../libs/codegen/dist/media-types.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.isMediaTypeMultipartFormData = exports.isMediaTypeXml = exports.isMediaTypeJson = exports.normalizeMediaType = exports.knownMediaType = exports.parseMediaType = exports.FormatType = exports.KnownMediaType = void 0;
// Media Type is: type "/" [tree "."] subtype ["+" suffix] * [";" parameter]
const json = "json";
const xml = "xml";
const application = "application";
const text = "text";
const multipart = "multipart";
const formData = "form-data";
const formEncoded = "x-www-form-urlencoded";
var KnownMediaType;
(function (KnownMediaType) {
    KnownMediaType["Json"] = "json";
    KnownMediaType["Xml"] = "xml";
    KnownMediaType["Form"] = "form";
    KnownMediaType["Binary"] = "binary";
    KnownMediaType["Multipart"] = "multipart";
    KnownMediaType["Text"] = "text";
    KnownMediaType["Unknown"] = "unknown";
})(KnownMediaType = exports.KnownMediaType || (exports.KnownMediaType = {}));
var FormatType;
(function (FormatType) {
    FormatType["QueryParameter"] = "-query-parameter-";
    FormatType["UriParameter"] = "-uri-parameter-";
    FormatType["Header"] = "-header-";
    FormatType["Cookie"] = "-cookie-";
})(FormatType = exports.FormatType || (exports.FormatType = {}));
function parseMediaType(mediaType) {
    if (mediaType) {
        const parsed = /(application|audio|font|example|image|message|model|multipart|text|video|x-(?:[0-9A-Za-z!#$%&'*+.^_`|~-]+))\/([0-9A-Za-z!#$%&'*.^_`|~-]+)\s*(?:\+([0-9A-Za-z!#$%&'*.^_`|~-]+))?\s*(?:;.\s*(\S*))?/g.exec(mediaType);
        if (parsed) {
            return {
                type: parsed[1],
                subtype: parsed[2],
                suffix: parsed[3],
                parameter: parsed[4],
            };
        }
    }
    return undefined;
}
exports.parseMediaType = parseMediaType;
function knownMediaType(mediaType) {
    const mt = parseMediaType(mediaType);
    if (mt) {
        if ((mt.subtype === json || mt.suffix === json) && (mt.type === application || mt.type === text)) {
            return KnownMediaType.Json;
        }
        if ((mt.subtype === xml || mt.suffix === xml) && (mt.type === application || mt.type === text)) {
            return KnownMediaType.Xml;
        }
        if (mt.type === "audio" || mt.type === "image" || mt.type === "video" || mt.subtype === "octet-stream") {
            return KnownMediaType.Binary;
        }
        if (mt.type === application && mt.subtype === formEncoded) {
            return KnownMediaType.Form;
        }
        if (mt.type === "multipart" && mt.subtype === "form-data") {
            return KnownMediaType.Multipart;
        }
        if (mt.type === application) {
            // at this point, an unrecognized application/* is considered a binary format
            // since we don't have any other way of dealing with it.
            return KnownMediaType.Binary;
        }
        if (mt.type === "text") {
            return KnownMediaType.Text;
        }
    }
    // pseudo-media types for figuring out how to de/serialize from from/to other types.
    /* switch (mediaType) {
      case 'header':
        return KnownMediaType.Header;
      case 'cookie':
        return KnownMediaType.Cookie;
      case 'urlencoding':
        return KnownMediaType.Cookie;
    }
    */
    return KnownMediaType.Unknown;
}
exports.knownMediaType = knownMediaType;
function normalizeMediaType(contentType) {
    if (contentType) {
        const mt = parseMediaType(contentType);
        if (mt) {
            return mt.suffix ? `${mt.type}/${mt.subtype}+${mt.suffix}` : `${mt.type}/${mt.subtype}`;
        }
    }
    return undefined;
}
exports.normalizeMediaType = normalizeMediaType;
function isMediaTypeJson(mediaType) {
    const mt = parseMediaType(mediaType);
    return mt ? (mt.subtype === json || mt.suffix === json) && (mt.type === application || mt.type === text) : false;
}
exports.isMediaTypeJson = isMediaTypeJson;
function isMediaTypeXml(mediaType) {
    const mt = parseMediaType(mediaType);
    return mt ? (mt.subtype === xml || mt.suffix === xml) && (mt.type === application || mt.type === text) : false;
}
exports.isMediaTypeXml = isMediaTypeXml;
function isMediaTypeMultipartFormData(mediaType) {
    const mt = parseMediaType(mediaType);
    return mt ? mt.type === multipart && mt.subtype === formData : false;
}
exports.isMediaTypeMultipartFormData = isMediaTypeMultipartFormData;
//# sourceMappingURL=media-types.js.map

/***/ }),

/***/ "../../libs/codegen/dist/pluralization.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.EnglishPluralizationService = void 0;
const text_manipulation_1 = __webpack_require__("../../libs/codegen/dist/text-manipulation.js");
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
/*
 * PORTED FROM System.Data.Entity.Infrastructure.Pluralization.EnglishPluralizationService (EntityFramework.dll)
 */
class StringBidirectionalDictionary {
    constructor(dict = {}) {
        this.dictForward = new Map();
        this.dictBackward = new Map();
        for (const key of Object.keys(dict)) {
            const value = dict[key];
            this.addValue(key, value);
        }
    }
    addValue(first, second) {
        this.dictForward.set(first, second);
        this.dictBackward.set(second, first);
    }
    existsInFirst(s) {
        return this.dictForward.has(s);
    }
    existsInSecond(s) {
        return this.dictBackward.has(s);
    }
    getFirstValue(s) {
        return (this.dictBackward.get(s) ||
            (() => {
                throw new Error("Cannot find key.");
            })());
    }
    getSecondValue(s) {
        return (this.dictForward.get(s) ||
            (() => {
                throw new Error("Cannot find key.");
            })());
    }
}
function endsWithIgnoreCase(word, suffix) {
    return word.toLowerCase().endsWith(suffix.toLowerCase());
}
class PluralizationServiceUtil {
    static DoesWordContainSuffix(word, suffixes) {
        return suffixes.some((s) => endsWithIgnoreCase(word, s));
    }
    static TryInflectOnSuffixInWord(word, suffixes, operationOnWord) {
        if (PluralizationServiceUtil.DoesWordContainSuffix(word, suffixes)) {
            return operationOnWord(word);
        }
        else {
            return null;
        }
    }
}
class EnglishPluralizationService {
    constructor() {
        this.uninflectiveSuffixList = ["fish", "ois", "sheep", "deer", "pos", "itis", "ism"];
        this.uninflectiveWordList = [
            "bison",
            "flounder",
            "pliers",
            "bream",
            "gallows",
            "proceedings",
            "breeches",
            "graffiti",
            "rabies",
            "britches",
            "headquarters",
            "salmon",
            "carp",
            "----",
            "scissors",
            "ch----is",
            "high-jinks",
            "sea-bass",
            "clippers",
            "homework",
            "series",
            "cod",
            "innings",
            "shears",
            "contretemps",
            "jackanapes",
            "species",
            "corps",
            "mackerel",
            "swine",
            "debris",
            "measles",
            "trout",
            "diabetes",
            "mews",
            "tuna",
            "djinn",
            "mumps",
            "whiting",
            "eland",
            "news",
            "wildebeest",
            "elk",
            "pincers",
            "police",
            "hair",
            "ice",
            "chaos",
            "milk",
            "cotton",
            "pneumonoultramicroscopicsilicovolcanoconiosis",
            "information",
            "aircraft",
            "scabies",
            "traffic",
            "corn",
            "millet",
            "rice",
            "hay",
            "----",
            "tobacco",
            "cabbage",
            "okra",
            "broccoli",
            "asparagus",
            "lettuce",
            "beef",
            "pork",
            "venison",
            "mutton",
            "cattle",
            "offspring",
            "molasses",
            "shambles",
            "shingles",
            "https",
            "sas",
            "statuses",
            "as",
            "statistics",
            "alias",
            "dns",
            "ms",
            "os",
            "vmss",
            "acls",
            "rights",
            "credentials",
            "ddos",
            "media",
            "gbps",
            "kbps",
            "mbps",
            "bps",
            "fips",
        ];
        this.irregularVerbList = {
            am: "are",
            are: "are",
            is: "are",
            was: "were",
            were: "were",
            has: "have",
            have: "have",
        };
        this.pronounList = [
            "I",
            "we",
            "you",
            "he",
            "she",
            "they",
            "it",
            "me",
            "us",
            "him",
            "her",
            "them",
            "myself",
            "ourselves",
            "yourself",
            "himself",
            "herself",
            "itself",
            "oneself",
            "oneselves",
            "my",
            "our",
            "your",
            "his",
            "their",
            "its",
            "mine",
            "yours",
            "hers",
            "theirs",
            "this",
            "that",
            "these",
            "those",
            "all",
            "another",
            "any",
            "anybody",
            "anyone",
            "anything",
            "both",
            "each",
            "other",
            "either",
            "everyone",
            "everybody",
            "everything",
            "most",
            "much",
            "nothing",
            "nobody",
            "none",
            "one",
            "others",
            "some",
            "somebody",
            "someone",
            "something",
            "what",
            "whatever",
            "which",
            "whichever",
            "who",
            "whoever",
            "whom",
            "whomever",
            "whose",
        ];
        this.irregularPluralsDictionary = {
            brother: "brothers",
            child: "children",
            cow: "cows",
            ephemeris: "ephemerides",
            genie: "genies",
            money: "moneys",
            mongoose: "mongooses",
            mythos: "mythoi",
            octopus: "octopuses",
            ox: "oxen",
            soliloquy: "soliloquies",
            trilby: "trilbys",
            crisis: "crises",
            synopsis: "synopses",
            rose: "roses",
            gas: "gases",
            bus: "buses",
            axis: "axes",
            memo: "memos",
            casino: "casinos",
            silo: "silos",
            stereo: "stereos",
            studio: "studios",
            lens: "lenses",
            alias: "aliases",
            pie: "pies",
            corpus: "corpora",
            viscus: "viscera",
            hippopotamus: "hippopotami",
            trace: "traces",
            person: "people",
            chili: "chilies",
            analysis: "analyses",
            basis: "bases",
            neurosis: "neuroses",
            oasis: "oases",
            synthesis: "syntheses",
            thesis: "theses",
            change: "changes",
            lie: "lies",
            calorie: "calories",
            freebie: "freebies",
            case: "cases",
            house: "houses",
            valve: "valves",
            cloth: "clothes",
            tie: "ties",
            movie: "movies",
            bonus: "bonuses",
            specimen: "specimens",
        };
        this.assimilatedClassicalInflectionDictionary = {
            alumna: "alumnae",
            alga: "algae",
            vertebra: "vertebrae",
            codex: "codices",
            murex: "murices",
            silex: "silices",
            aphelion: "aphelia",
            hyperbaton: "hyperbata",
            perihelion: "perihelia",
            asyndeton: "asyndeta",
            noumenon: "noumena",
            phenomenon: "phenomena",
            criterion: "criteria",
            organon: "organa",
            prolegomenon: "prolegomena",
            agendum: "agenda",
            extremum: "extrema",
            bacterium: "bacteria",
            desideratum: "desiderata",
            stratum: "strata",
            candelabrum: "candelabra",
            erratum: "errata",
            ovum: "ova",
            forum: "fora",
            addendum: "addenda",
            stadium: "stadia",
            automaton: "automata",
            polyhedron: "polyhedra",
        };
        this.oSuffixDictionary = {
            albino: "albinos",
            generalissimo: "generalissimos",
            manifesto: "manifestos",
            archipelago: "archipelagos",
            ghetto: "ghettos",
            medico: "medicos",
            armadillo: "armadillos",
            guano: "guanos",
            octavo: "octavos",
            commando: "commandos",
            inferno: "infernos",
            photo: "photos",
            ditto: "dittos",
            jumbo: "jumbos",
            pro: "pros",
            dynamo: "dynamos",
            lingo: "lingos",
            quarto: "quartos",
            embryo: "embryos",
            lumbago: "lumbagos",
            rhino: "rhinos",
            fiasco: "fiascos",
            magneto: "magnetos",
            stylo: "stylos",
        };
        this.classicalInflectionDictionary = {
            stamen: "stamina",
            foramen: "foramina",
            lumen: "lumina",
            anathema: "anathemata",
            "----": "----ta",
            oedema: "oedemata",
            bema: "bemata",
            enigma: "enigmata",
            sarcoma: "sarcomata",
            carcinoma: "carcinomata",
            gumma: "gummata",
            schema: "schemata",
            charisma: "charismata",
            lemma: "lemmata",
            soma: "somata",
            diploma: "diplomata",
            lymphoma: "lymphomata",
            stigma: "stigmata",
            dogma: "dogmata",
            magma: "magmata",
            stoma: "stomata",
            drama: "dramata",
            melisma: "melismata",
            trauma: "traumata",
            edema: "edemata",
            miasma: "miasmata",
            abscissa: "abscissae",
            formula: "formulae",
            medusa: "medusae",
            amoeba: "amoebae",
            hydra: "hydrae",
            nebula: "nebulae",
            antenna: "antennae",
            hyperbola: "hyperbolae",
            nova: "novae",
            aurora: "aurorae",
            lacuna: "lacunae",
            parabola: "parabolae",
            apex: "apices",
            latex: "latices",
            vertex: "vertices",
            cortex: "cortices",
            pontifex: "pontifices",
            vortex: "vortices",
            index: "indices",
            simplex: "simplices",
            iris: "irides",
            "----oris": "----orides",
            alto: "alti",
            contralto: "contralti",
            soprano: "soprani",
            "b----o": "b----i",
            crescendo: "crescendi",
            tempo: "tempi",
            canto: "canti",
            solo: "soli",
            aquarium: "aquaria",
            interregnum: "interregna",
            quantum: "quanta",
            compendium: "compendia",
            lustrum: "lustra",
            rostrum: "rostra",
            consortium: "consortia",
            maximum: "maxima",
            spectrum: "spectra",
            cranium: "crania",
            medium: "media",
            speculum: "specula",
            curriculum: "curricula",
            memorandum: "memoranda",
            stadium: "stadia",
            dictum: "dicta",
            millenium: "millenia",
            "t----zium": "t----zia",
            emporium: "emporia",
            minimum: "minima",
            ultimatum: "ultimata",
            enconium: "enconia",
            momentum: "momenta",
            vacuum: "vacua",
            gymnasium: "gymnasia",
            optimum: "optima",
            velum: "vela",
            honorarium: "honoraria",
            phylum: "phyla",
            focus: "foci",
            nimbus: "nimbi",
            succubus: "succubi",
            fungus: "fungi",
            nucleolus: "nucleoli",
            torus: "tori",
            genius: "genii",
            radius: "radii",
            umbilicus: "umbilici",
            incubus: "incubi",
            stylus: "styli",
            uterus: "uteri",
            stimulus: "stimuli",
            apparatus: "apparatus",
            impetus: "impetus",
            prospectus: "prospectus",
            cantus: "cantus",
            nexus: "nexus",
            sinus: "sinus",
            coitus: "coitus",
            plexus: "plexus",
            status: "status",
            hiatus: "hiatus",
            afreet: "afreeti",
            afrit: "afriti",
            efreet: "efreeti",
            cherub: "cherubim",
            goy: "goyim",
            seraph: "seraphim",
            alumnus: "alumni",
        };
        // this list contains all the plural words that being treated as singluar form, for example, "they" -> "they"
        this.knownConflictingPluralList = ["they", "them", "their", "have", "were", "yourself", "are"];
        // this list contains the words ending with "se" and we special case these words since
        // we need to add a rule for "ses" singularize to "s"
        this.wordsEndingWithSeDictionary = {
            house: "houses",
            case: "cases",
            enterprise: "enterprises",
            purchase: "purchases",
            surprise: "surprises",
            release: "releases",
            disease: "diseases",
            promise: "promises",
            refuse: "refuses",
            whose: "whoses",
            phase: "phases",
            noise: "noises",
            nurse: "nurses",
            rose: "roses",
            franchise: "franchises",
            supervise: "supervises",
            farmhouse: "farmhouses",
            suitcase: "suitcases",
            recourse: "recourses",
            impulse: "impulses",
            license: "licenses",
            diocese: "dioceses",
            excise: "excises",
            demise: "demises",
            blouse: "blouses",
            bruise: "bruises",
            misuse: "misuses",
            curse: "curses",
            prose: "proses",
            purse: "purses",
            goose: "gooses",
            tease: "teases",
            poise: "poises",
            vase: "vases",
            fuse: "fuses",
            muse: "muses",
            slaughterhouse: "slaughterhouses",
            clearinghouse: "clearinghouses",
            endonuclease: "endonucleases",
            steeplechase: "steeplechases",
            metamorphose: "metamorphoses",
            "----": "----s",
            commonsense: "commonsenses",
            intersperse: "intersperses",
            merchandise: "merchandises",
            phosphatase: "phosphatases",
            summerhouse: "summerhouses",
            watercourse: "watercourses",
            catchphrase: "catchphrases",
            compromise: "compromises",
            greenhouse: "greenhouses",
            lighthouse: "lighthouses",
            paraphrase: "paraphrases",
            mayonnaise: "mayonnaises",
            "----course": "----courses",
            apocalypse: "apocalypses",
            courthouse: "courthouses",
            powerhouse: "powerhouses",
            storehouse: "storehouses",
            glasshouse: "glasshouses",
            hypotenuse: "hypotenuses",
            peroxidase: "peroxidases",
            pillowcase: "pillowcases",
            roundhouse: "roundhouses",
            streetwise: "streetwises",
            expertise: "expertises",
            discourse: "discourses",
            warehouse: "warehouses",
            staircase: "staircases",
            workhouse: "workhouses",
            briefcase: "briefcases",
            clubhouse: "clubhouses",
            clockwise: "clockwises",
            concourse: "concourses",
            playhouse: "playhouses",
            turquoise: "turquoises",
            boathouse: "boathouses",
            cellulose: "celluloses",
            epitomise: "epitomises",
            gatehouse: "gatehouses",
            grandiose: "grandioses",
            menopause: "menopauses",
            penthouse: "penthouses",
            "----horse": "----horses",
            transpose: "transposes",
            almshouse: "almshouses",
            customise: "customises",
            footloose: "footlooses",
            galvanise: "galvanises",
            princesse: "princesses",
            universe: "universes",
            workhorse: "workhorses",
            response: "responses",
            phrase: "phrases",
        };
        this.wordsEndingWithSisDictionary = {
            analysis: "analyses",
            crisis: "crises",
            basis: "bases",
            atherosclerosis: "atheroscleroses",
            electrophoresis: "electrophoreses",
            psychoanalysis: "psychoanalyses",
            photosynthesis: "photosyntheses",
            amniocentesis: "amniocenteses",
            metamorphosis: "metamorphoses",
            toxoplasmosis: "toxoplasmoses",
            endometriosis: "endometrioses",
            tuberculosis: "tuberculoses",
            pathogenesis: "pathogeneses",
            osteoporosis: "osteoporoses",
            parenthesis: "parentheses",
            anastomosis: "anastomoses",
            peristalsis: "peristalses",
            hypothesis: "hypotheses",
            antithesis: "antitheses",
            apotheosis: "apotheoses",
            thrombosis: "thromboses",
            diagnosis: "diagnoses",
            synthesis: "syntheses",
            paralysis: "paralyses",
            prognosis: "prognoses",
            cirrhosis: "cirrhoses",
            sclerosis: "scleroses",
            psychosis: "psychoses",
            apoptosis: "apoptoses",
            symbiosis: "symbioses",
            redis: "redis",
        };
        this.wordsEndingWithSusDictionary = {
            consensus: "consensuses",
            census: "censuses",
            status: "statuses",
        };
        this.wordsEndingWithInxAnxYnxDictionary = {
            sphinx: "sphinxes",
            larynx: "larynges",
            lynx: "lynxes",
            pharynx: "pharynxes",
            phalanx: "phalanxes",
        };
        // eslint-disable-next-line prefer-spread
        const flatten = (l) => [].concat.apply([], l);
        this.userDictionary = new StringBidirectionalDictionary();
        this.irregularPluralsPluralizationService = new StringBidirectionalDictionary(this.irregularPluralsDictionary);
        this.assimilatedClassicalInflectionPluralizationService = new StringBidirectionalDictionary(this.assimilatedClassicalInflectionDictionary);
        this.oSuffixPluralizationService = new StringBidirectionalDictionary(this.oSuffixDictionary);
        this.classicalInflectionPluralizationService = new StringBidirectionalDictionary(this.classicalInflectionDictionary);
        this.wordsEndingWithSePluralizationService = new StringBidirectionalDictionary(this.wordsEndingWithSeDictionary);
        this.wordsEndingWithSisPluralizationService = new StringBidirectionalDictionary(this.wordsEndingWithSisDictionary);
        this.wordsEndingWithSusPluralizationService = new StringBidirectionalDictionary(this.wordsEndingWithSusDictionary);
        this.wordsEndingWithInxAnxYnxPluralizationService = new StringBidirectionalDictionary(this.wordsEndingWithInxAnxYnxDictionary);
        // verb
        this.irregularVerbPluralizationService = new StringBidirectionalDictionary(this.irregularVerbList);
        this.knownSingluarWords = flatten([
            Object.keys(this.irregularPluralsDictionary),
            Object.keys(this.assimilatedClassicalInflectionDictionary),
            Object.keys(this.oSuffixDictionary),
            Object.keys(this.classicalInflectionDictionary),
            Object.keys(this.irregularVerbList),
            Object.keys(this.irregularPluralsDictionary),
            Object.keys(this.wordsEndingWithSeDictionary),
            Object.keys(this.wordsEndingWithSisDictionary),
            Object.keys(this.wordsEndingWithSusDictionary),
            Object.keys(this.wordsEndingWithInxAnxYnxDictionary),
            Object.keys(this.uninflectiveWordList),
        ]).filter((x) => !this.knownConflictingPluralList.includes(x)); // see the _knowConflictingPluralList comment above
        this.knownPluralWords = flatten([
            Object.values(this.irregularPluralsDictionary),
            Object.values(this.assimilatedClassicalInflectionDictionary),
            Object.values(this.oSuffixDictionary),
            Object.values(this.classicalInflectionDictionary),
            Object.values(this.irregularVerbList),
            Object.values(this.irregularPluralsDictionary),
            Object.values(this.wordsEndingWithSeDictionary),
            Object.values(this.wordsEndingWithSisDictionary),
            Object.values(this.wordsEndingWithSusDictionary),
            Object.values(this.wordsEndingWithInxAnxYnxDictionary),
            Object.values(this.uninflectiveWordList),
        ]);
    }
    isPlural(word) {
        if (this.userDictionary.existsInSecond(word)) {
            return true;
        }
        if (this.userDictionary.existsInFirst(word)) {
            return false;
        }
        if (this.isUninflective(word) || this.knownPluralWords.includes(word.toLowerCase())) {
            return true;
        }
        else if (this.singularize(word) === word) {
            return false;
        }
        else {
            return true;
        }
    }
    isSingular(word) {
        if (this.userDictionary.existsInFirst(word)) {
            return true;
        }
        if (this.userDictionary.existsInSecond(word)) {
            return false;
        }
        if (this.isUninflective(word) || this.knownSingluarWords.includes(word.toLowerCase())) {
            return true;
        }
        else if (!this.isNoOpWord(word) && this.singularize(word) === word) {
            return true;
        }
        else {
            return false;
        }
    }
    //
    pluralize(word) {
        return this.capitalize(word, (w) => this.internalPluralize(w));
    }
    internalPluralize(word) {
        // words that we know of
        if (this.userDictionary.existsInFirst(word)) {
            return this.userDictionary.getSecondValue(word);
        }
        if (this.isNoOpWord(word)) {
            return word;
        }
        const { prefixWord, suffixWord } = this.getSuffixWord(word);
        // by me -> by me
        if (this.isNoOpWord(suffixWord)) {
            return prefixWord + suffixWord;
        }
        // handle the word that do not inflect in the plural form
        if (this.isUninflective(suffixWord)) {
            return prefixWord + suffixWord;
        }
        // if word is one of the known plural forms, then just return
        if (this.knownPluralWords.includes(suffixWord.toLowerCase()) || this.isPlural(suffixWord)) {
            return prefixWord + suffixWord;
        }
        // handle irregular plurals, e.g. "ox" -> "oxen"
        if (this.irregularPluralsPluralizationService.existsInFirst(suffixWord)) {
            return prefixWord + this.irregularPluralsPluralizationService.getSecondValue(suffixWord);
        }
        let newSuffixWord;
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["man"], (s) => `${s.slice(0, -2)}en`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // handle irregular inflections for common suffixes, e.g. "mouse" -> "mice"
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["louse", "mouse"], (s) => `${s.slice(0, -4)}ice`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["tooth"], (s) => `${s.slice(0, -4)}eeth`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["goose"], (s) => `${s.slice(0, -4)}eese`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["foot"], (s) => `${s.slice(0, -3)}eet`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["zoon"], (s) => `${s.slice(0, -3)}oa`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["cis", "sis", "xis"], (s) => `${s.slice(0, -2)}es`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // handle assimilated classical inflections, e.g. vertebra -> vertebrae
        if (this.assimilatedClassicalInflectionPluralizationService.existsInFirst(suffixWord)) {
            return prefixWord + this.assimilatedClassicalInflectionPluralizationService.getSecondValue(suffixWord);
        }
        // Handle the classical variants of modern inflections
        //
        if (this.classicalInflectionPluralizationService.existsInFirst(suffixWord)) {
            return prefixWord + this.classicalInflectionPluralizationService.getSecondValue(suffixWord);
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["trix"], (s) => `${s.slice(0, -1)}ces`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["eau", "ieu"], (s) => `${s}x`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        if (this.wordsEndingWithInxAnxYnxPluralizationService.existsInFirst(suffixWord)) {
            return prefixWord + this.wordsEndingWithInxAnxYnxPluralizationService.getSecondValue(suffixWord);
        }
        // [cs]h and ss that take es as plural form
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["ch", "sh", "ss"], (s) => `${s}es`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // f, fe that take ves as plural form
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["alf", "elf", "olf", "eaf", "arf"], (s) => (endsWithIgnoreCase(s, "deaf") ? s : `${s.slice(0, -1)}ves`));
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["nife", "life", "wife"], (s) => `${s.slice(0, -2)}ves`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // y takes ys as plural form if preceded by a vowel, but ies if preceded by a consonant, e.g. stays, skies
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["ay", "ey", "iy", "oy", "uy"], (s) => `${s}s`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        //
        if (endsWithIgnoreCase(suffixWord, "y")) {
            return prefixWord + suffixWord.slice(0, -1) + "ies";
        }
        // handle some of the words o -> os, and [vowel]o -> os, and the rest are o->oes
        if (this.oSuffixPluralizationService.existsInFirst(suffixWord)) {
            return prefixWord + this.oSuffixPluralizationService.getSecondValue(suffixWord);
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["ao", "eo", "io", "oo", "uo"], (s) => `${s}s`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        if (endsWithIgnoreCase(suffixWord, "o") || endsWithIgnoreCase(suffixWord, "s")) {
            return `${prefixWord}${suffixWord}es`;
        }
        if (endsWithIgnoreCase(suffixWord, "x")) {
            return `${prefixWord}${suffixWord}es`;
        }
        // cats, bags, hats, speakers
        return `${prefixWord}${suffixWord}s`;
    }
    singularize(word) {
        if (!word) {
            return word;
        }
        // split it up.
        const de = (0, text_manipulation_1.deconstruct)(word);
        // singularize the last word only
        de[de.length - 1] = this.capitalize(de[de.length - 1], (w) => this.internalSingularize(w));
        // return the pascal cased whole thing.
        return (0, text_manipulation_1.pascalCase)(de);
    }
    internalSingularize(word) {
        // words that we know of
        if (this.userDictionary.existsInSecond(word)) {
            return this.userDictionary.getFirstValue(word);
        }
        if (this.isNoOpWord(word)) {
            return word;
        }
        const { prefixWord, suffixWord } = this.getSuffixWord(word);
        if (this.isNoOpWord(suffixWord)) {
            return prefixWord + suffixWord;
        }
        // handle the word that is the same as the plural form
        if (this.isUninflective(suffixWord)) {
            return prefixWord + suffixWord;
        }
        // if word is one of the known singular words, then just return
        if (this.knownSingluarWords.includes(suffixWord.toLowerCase())) {
            return prefixWord + suffixWord;
        }
        // handle simple irregular verbs, e.g. was -> were
        if (this.irregularVerbPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.irregularVerbPluralizationService.getFirstValue(suffixWord);
        }
        // handle irregular plurals, e.g. "ox" -> "oxen"
        if (this.irregularPluralsPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.irregularPluralsPluralizationService.getFirstValue(suffixWord);
        }
        // handle singluarization for words ending with sis and pluralized to ses,
        // e.g. "ses" -> "sis"
        if (this.wordsEndingWithSisPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.wordsEndingWithSisPluralizationService.getFirstValue(suffixWord);
        }
        // handle words ending with se, e.g. "ses" -> "se"
        if (this.wordsEndingWithSePluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.wordsEndingWithSePluralizationService.getFirstValue(suffixWord);
        }
        // handle words ending with sus, e.g. "suses" -> "sus"
        if (this.wordsEndingWithSusPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.wordsEndingWithSusPluralizationService.getFirstValue(suffixWord);
        }
        let newSuffixWord;
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["men"], (s) => `${s.slice(0, -2)}an`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // handle irregular inflections for common suffixes, e.g. "mouse" -> "mice"
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["lice", "mice"], (s) => `${s.slice(0, -3)}ouse`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["teeth"], (s) => `${s.slice(0, -4)}ooth`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["geese"], (s) => `${s.slice(0, -4)}oose`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["feet"], (s) => `${s.slice(0, -3)}oot`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["zoa"], (s) => `${s.slice(0, -2)}oon`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // [cs]h and ss that take es as plural form, this is being moved up since the sses will be override by the ses
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["ches", "shes", "sses"], (s) => s.slice(0, -2));
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // handle assimilated classical inflections, e.g. vertebra -> vertebrae
        if (this.assimilatedClassicalInflectionPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.assimilatedClassicalInflectionPluralizationService.getFirstValue(suffixWord);
        }
        // Handle the classical variants of modern inflections
        //
        if (this.classicalInflectionPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.classicalInflectionPluralizationService.getFirstValue(suffixWord);
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["trices"], (s) => `${s.slice(0, -3)}x`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["eaux", "ieux"], (s) => s.slice(0, -1));
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        if (this.wordsEndingWithInxAnxYnxPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.wordsEndingWithInxAnxYnxPluralizationService.getFirstValue(suffixWord);
        }
        // f, fe that take ves as plural form
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["alves", "elves", "olves", "eaves", "arves"], (s) => `${s.slice(0, -3)}f`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["nives", "lives", "wives"], (s) => `${s.slice(0, -3)}fe`);
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        // y takes ys as plural form if preceded by a vowel, but ies if preceded by a consonant, e.g. stays, skies
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["ays", "eys", "iys", "oys", "uys"], (s) => s.slice(0, -1));
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        //
        if (endsWithIgnoreCase(suffixWord, "ies")) {
            return prefixWord + suffixWord.slice(0, -3) + "y";
        }
        // handle some of the words o -> os, and [vowel]o -> os, and the rest are o->oes
        if (this.oSuffixPluralizationService.existsInSecond(suffixWord)) {
            return prefixWord + this.oSuffixPluralizationService.getFirstValue(suffixWord);
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["aos", "eos", "ios", "oos", "uos"], (s) => s.slice(0, -1));
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        //
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["ces"], (s) => s.slice(0, -1));
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        newSuffixWord = PluralizationServiceUtil.TryInflectOnSuffixInWord(suffixWord, ["ces", "ses", "xes"], (s) => s.slice(0, -2));
        if (newSuffixWord !== null) {
            return prefixWord + newSuffixWord;
        }
        if (endsWithIgnoreCase(suffixWord, "oes")) {
            return prefixWord + suffixWord.slice(0, -2);
        }
        if (endsWithIgnoreCase(suffixWord, "ss")) {
            return prefixWord + suffixWord;
        }
        if (endsWithIgnoreCase(suffixWord, "s")) {
            return prefixWord + suffixWord.slice(0, -1);
        }
        // word is a singlar
        return prefixWord + suffixWord;
    }
    /// <summary>
    /// captalize the return word if the parameter is capitalized
    /// if word is "Table", then return "Tables"
    /// </summary>
    /// <param name="word"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    capitalize(word, action) {
        const result = action(word);
        if (this.isCapitalized(word)) {
            if (result.length === 0) {
                return result;
            }
            return result.charAt(0).toUpperCase() + result.substr(1);
        }
        else {
            return result;
        }
    }
    /// <summary>
    /// separate one combine word in to two parts, prefix word and the last word(suffix word)
    /// </summary>
    /// <param name="word"></param>
    /// <param name="prefixWord"></param>
    /// <returns></returns>
    getSuffixWord(word) {
        // use the last space to separate the words
        const lastSpaceIndex = word.lastIndexOf(" ");
        return {
            prefixWord: word.substr(0, lastSpaceIndex + 1),
            suffixWord: word.substr(lastSpaceIndex + 1),
        };
        //
    }
    isCapitalized(word) {
        if (word === "") {
            return false;
        }
        return word.charAt(0) == word.charAt(0).toUpperCase();
    }
    isAlphabets(word) {
        // return false when the word is "[\s]*" or leading or tailing with spaces
        // or contains non alphabetical characters
        if (word === "" || word !== word.trim() || /[^a-zA-Z\\s]/.test(word)) {
            return false;
        }
        else {
            return true;
        }
    }
    isUninflective(word) {
        if (PluralizationServiceUtil.DoesWordContainSuffix(word, this.uninflectiveSuffixList) ||
            (word.toLowerCase() !== word && word.endsWith("ese")) ||
            this.uninflectiveWordList.includes(word.toLowerCase())) {
            return true;
        }
        else {
            return false;
        }
    }
    /// <summary>
    /// return true when the word is "[\s]*" or leading or tailing with spaces
    /// or contains non alphabetical characters
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    isNoOpWord(word) {
        if (!this.isAlphabets(word) || word.length <= 1 || this.pronounList.includes(word.toLowerCase())) {
            return true;
        }
        else {
            return false;
        }
    }
    /// <summary>
    /// This method allow you to add word to internal PluralizationService of English.
    /// If the singluar or the plural value was already added by this method, then an ArgumentException will be thrown.
    /// </summary>
    /// <param name="singular"></param>
    /// <param name="plural"></param>
    addWord(singular, plural) {
        if (this.userDictionary.existsInSecond(plural)) {
            throw new Error(`The plural value '${plural}' already exists in the user-defined dictionary.`);
        }
        else if (this.userDictionary.existsInFirst(singular)) {
            throw new Error(`The singular value '${singular}' already exists in the user-defined dictionary.`);
        }
        else {
            this.userDictionary.addValue(singular, plural);
        }
    }
}
exports.EnglishPluralizationService = EnglishPluralizationService;
//# sourceMappingURL=pluralization.js.map

/***/ }),

/***/ "../../libs/codegen/dist/safe-eval.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.createSandbox = exports.safeEval = void 0;
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
const vm = __importStar(__webpack_require__("vm"));
/**
 * A sandboxed eval function
 *
 * @deprecated consumers should create a local sandbox to reuse. (@see createSandbox )
 *  */
exports.safeEval = createSandbox();
/**
 * Creates a reusable safe-eval sandbox to execute code in.
 */
function createSandbox() {
    const sandbox = vm.createContext({});
    return (code, context) => {
        const response = "SAFE_EVAL_" + Math.floor(Math.random() * 1000000);
        sandbox[response] = {};
        if (context) {
            for (const key of Object.keys(context)) {
                sandbox[key] = context[key];
            }
            vm.runInContext(`${response} = ${code}`, sandbox);
            for (const key of Object.keys(context)) {
                delete sandbox[key];
            }
        }
        else {
            vm.runInContext(`${response} = ${code}`, sandbox);
        }
        return sandbox[response];
    };
}
exports.createSandbox = createSandbox;
//# sourceMappingURL=safe-eval.js.map

/***/ }),

/***/ "../../libs/codegen/dist/source-track.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.shadowPosition = exports.ShadowedNodePath = exports.enableSourceTracking = exports.getMappings = void 0;
const type_1 = __webpack_require__("../../libs/codegen/dist/type.js");
const getMap = "_#get-map#_";
const getPosition = "_#get-position#_";
const getActualValue = "_#get-value#_";
function getMappings(instance) {
    return instance[getMap];
}
exports.getMappings = getMappings;
function enableSourceTracking(instance, enforce = true, path = "$", map = {}, cache = new Map()) {
    let proxy = cache.get(path);
    if (!proxy) {
        proxy = new Proxy(instance, {
            get: (target, p, receiver) => {
                if (p === getMap) {
                    return map;
                }
                const value = target[p];
                switch ((0, type_1.typeOf)(value)) {
                    case "undefined":
                    case "null":
                    case "function":
                    case "string":
                    case "boolean":
                    case "number":
                        return value;
                    case "array":
                        return enableSourceTracking(value, enforce, `${path}[${String(p)}]`, map, cache);
                    case "object":
                        return enableSourceTracking(value, enforce, `${path}.${String(p)}`, map, cache);
                }
                throw new Error(`Unhandled type withMap for '${(0, type_1.typeOf)(value)}'`);
            },
            set: (target, p, value, receiver) => {
                let memberPath = "";
                switch ((0, type_1.typeOf)(target)) {
                    case "array":
                        memberPath = `${path}[${String(p)}]`;
                        break;
                    case "object":
                        memberPath = `${path}.${String(p)}`;
                        break;
                    default:
                        throw new Error(`Unhandled 'set' for type withMap on '${(0, type_1.typeOf)(value)}'`);
                }
                if (value === undefined) {
                    // remove the existing value
                    delete target[p];
                    delete map[memberPath];
                    return true;
                }
                if (value === null) {
                    // remove the existing value
                    target[p] = null;
                    delete map[memberPath];
                    return true;
                }
                const pos = value[getPosition];
                if (pos) {
                    map[memberPath] = pos;
                    target[p] = value[getActualValue];
                    // TODO: we should actually iterate thru whole graph here and set the source locations
                    // for each item individually.
                    return true;
                }
                if (enforce) {
                    throw new Error(`Must supply source informaton on setting property '${memberPath}' when enforce is true.`);
                }
                target[p] = value.valueOf();
                return true;
            },
        });
        cache.set(path, proxy);
    }
    return proxy;
}
exports.enableSourceTracking = enableSourceTracking;
exports.ShadowedNodePath = Symbol("ObjectPosition");
function shadowPosition(source, path = []) {
    return new Proxy(source, {
        get(target, p) {
            if (p === exports.ShadowedNodePath) {
                // they want the source location for this node.
                return path;
            }
            const value = target[p];
            const key = getKey(p);
            switch ((0, type_1.typeOf)(value)) {
                case "undefined":
                case "null":
                case "function":
                case "string":
                case "boolean":
                case "number":
                    return value;
                case "array":
                    return shadowPosition(value, [...path, key]);
                case "object":
                    return shadowPosition(value, [...path, key]);
                default:
                    throw new Error(`Unhandled shadow of type '${(0, type_1.typeOf)(value)}' `);
            }
        },
    });
}
exports.shadowPosition = shadowPosition;
function getKey(p) {
    switch (typeof p) {
        case "symbol":
            return p.toString();
        case "number":
            return p;
        case "string": {
            return isNaN(p) || isNaN(parseFloat(p)) ? p : parseInt(p, 10);
        }
    }
}
//# sourceMappingURL=source-track.js.map

/***/ }),

/***/ "../../libs/codegen/dist/text-manipulation.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.selectName = exports._setRegion = exports.setRegion = exports.getRegions = exports.nameof = exports.escapeString = exports.getPascalIdentifier = exports.camelCase = exports.pascalCase = exports.removeSequentialDuplicates = exports.isEqual = exports.removeProhibitedPrefix = exports.fixLeadingNumber = exports.convert = exports.isCapitalized = exports.deconstruct = exports.pall = exports.__selectMany = exports.ToMap = exports.map = exports.dotCombine = exports.docComment = exports.comment = exports.indent = exports.fixEOL = exports.toMap = exports.trimDots = exports.setIndentation = exports.sortByName = exports.joinComma = exports.join = exports.uncapitalize = exports.capitalize = exports.CommaChar = exports.EOL = exports.docCommentPrefix = exports.lineCommentPrefix = void 0;
const file_generator_1 = __webpack_require__("../../libs/codegen/dist/file-generator.js");
let indentation = "    ";
exports.lineCommentPrefix = "//";
exports.docCommentPrefix = "///";
exports.EOL = "\n";
exports.CommaChar = ", ";
const acronyms = new Set([
    "ip",
    "os",
    "ms",
    "vm", //  'ssl', 'https', 'http', ''
]);
function capitalize(str) {
    if (acronyms.has(str)) {
        return str.toUpperCase();
    }
    return str ? `${str.charAt(0).toUpperCase()}${str.substr(1)}` : str;
}
exports.capitalize = capitalize;
function uncapitalize(str) {
    return str ? `${str.charAt(0).toLowerCase()}${str.substr(1)}` : str;
}
exports.uncapitalize = uncapitalize;
function join(items, separator) {
    return items.filter((v) => (v ? true : false)).join(separator);
}
exports.join = join;
function joinComma(items, mapFn) {
    return join(items.map(mapFn), exports.CommaChar);
}
exports.joinComma = joinComma;
function sortByName(a, b) {
    return a.name < b.name ? -1 : a.name > b.name ? 1 : 0;
}
exports.sortByName = sortByName;
function setIndentation(spaces) {
    indentation = " ".repeat(spaces);
}
exports.setIndentation = setIndentation;
function trimDots(content) {
    return content.replace(/^[.\s]*(.*?)[.\s]*$/g, "$1");
}
exports.trimDots = trimDots;
function toMap(source, eachFn) {
    const result = new Map();
    for (const each of source) {
        const key = eachFn(each);
        let values = result.get(key);
        if (!values) {
            values = new Array();
            result.set(key, values);
        }
        values.push(each);
    }
    return result;
}
exports.toMap = toMap;
function fixEOL(content) {
    return content.replace(/\r\n/g, exports.EOL);
}
exports.fixEOL = fixEOL;
function indent(content, factor = 1) {
    const i = indentation.repeat(factor);
    content = i + fixEOL(content.trim());
    return content.split(/\n/g).join(`${exports.EOL}${i}`);
}
exports.indent = indent;
function comment(content, prefix = exports.lineCommentPrefix, factor = 0, maxLength = 120) {
    const result = new Array();
    let line = "";
    prefix = indent(prefix, factor);
    content = content.trim();
    if (content) {
        for (const word of content.replace(/\n+/g, " ?? ").split(/\s+/g)) {
            if (word === "??") {
                result.push(line);
                line = prefix;
                continue;
            }
            if (maxLength < line.length) {
                result.push(line);
                line = "";
            }
            if (!line) {
                line = prefix;
            }
            line += ` ${word}`;
        }
        if (line) {
            result.push(line);
        }
        return result.join(exports.EOL);
    }
    return "";
}
exports.comment = comment;
function docComment(content, prefix = exports.docCommentPrefix, factor = 0, maxLength = 120) {
    return comment(content, prefix, factor, maxLength);
}
exports.docComment = docComment;
function dotCombine(prefix, content) {
    return trimDots([trimDots(prefix), trimDots(content)].join("."));
}
exports.dotCombine = dotCombine;
function map(dictionary, callbackfn, thisArg) {
    return Object.getOwnPropertyNames(dictionary).map((key) => callbackfn(key, dictionary[key]));
}
exports.map = map;
function ToMap(dictionary) {
    const result = new Map();
    Object.getOwnPropertyNames(dictionary).map((key) => result.set(key, dictionary[key]));
    return result;
}
exports.ToMap = ToMap;
function __selectMany(multiArray) {
    const result = new Array();
    multiArray.map((v) => result.push(...v));
    return result;
}
exports.__selectMany = __selectMany;
function pall(array, callbackfn, thisArg) {
    return Promise.all(array.map(callbackfn));
}
exports.pall = pall;
function deconstruct(identifier) {
    if (Array.isArray(identifier)) {
        return identifier.flatMap(deconstruct);
    }
    return `${identifier}`
        .replace(/([a-z]+)([A-Z])/g, "$1 $2")
        .replace(/(\d+)([a-z|A-Z]+)/g, "$1 $2")
        .replace(/\b([A-Z]+)([A-Z])([a-z])/, "$1 $2$3")
        .split(/[\W|_]+/)
        .map((each) => each.toLowerCase());
}
exports.deconstruct = deconstruct;
function isCapitalized(identifier) {
    return /^[A-Z]/.test(identifier);
}
exports.isCapitalized = isCapitalized;
const ones = [
    "",
    "one",
    "two",
    "three",
    "four",
    "five",
    "six",
    "seven",
    "eight",
    "nine",
    "ten",
    "eleven",
    "twelve",
    "thirteen",
    "fourteen",
    "fifteen",
    "sixteen",
    "seventeen",
    "eighteen",
    "nineteen",
];
const teens = (/* unused pure expression or super */ null && ([
    "ten",
    "eleven",
    "twelve",
    "thirteen",
    "fourteen",
    "fifteen",
    "sixteen",
    "seventeen",
    "eighteen",
    "nineteen",
]));
const tens = ["", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];
const magnitude = [
    "thousand",
    "million",
    "billion",
    "trillion",
    "quadrillion",
    "quintillion",
    "septillion",
    "octillion",
];
const magvalues = [10 ** 3, 10 ** 6, 10 ** 9, 10 ** 12, 10 ** 15, 10 ** 18, 10 ** 21, 10 ** 24, 10 ** 27];
function* convert(num) {
    if (!num) {
        yield "zero";
        return;
    }
    if (num > 1e30) {
        yield "lots";
        return;
    }
    if (num > 999) {
        for (let i = magvalues.length; i > -1; i--) {
            const c = magvalues[i];
            if (num > c) {
                yield* convert(Math.floor(num / c));
                yield magnitude[i];
                num = num % c;
            }
        }
    }
    if (num > 99) {
        yield ones[Math.floor(num / 100)];
        yield "hundred";
        num %= 100;
    }
    if (num > 19) {
        yield tens[Math.floor(num / 10)];
        num %= 10;
    }
    if (num) {
        yield ones[num];
    }
}
exports.convert = convert;
function fixLeadingNumber(identifier) {
    if (identifier.length > 0 && /^\d+/.exec(identifier[0])) {
        return [...convert(parseInt(identifier[0])), ...identifier.slice(1)];
    }
    return identifier;
}
exports.fixLeadingNumber = fixLeadingNumber;
function removeProhibitedPrefix(identifier, prohibitedPrefix, skipIdentifiers) {
    if (identifier.toLowerCase().startsWith(prohibitedPrefix.toLowerCase())) {
        const regex = new RegExp(`(^${prohibitedPrefix})(.*)`, "i");
        let newIdentifier = identifier.replace(regex, "$2");
        if (newIdentifier.length < 2) {
            // if it results in an empty string or a single letter string
            // then, it is not really a word.
            return identifier;
        }
        newIdentifier = isCapitalized(identifier) ? capitalize(newIdentifier) : uncapitalize(newIdentifier);
        return skipIdentifiers !== undefined
            ? skipIdentifiers.includes(newIdentifier)
                ? identifier
                : newIdentifier
            : newIdentifier;
    }
    return identifier;
}
exports.removeProhibitedPrefix = removeProhibitedPrefix;
function isEqual(s1, s2) {
    // when s2 is undefined and s1 is the string 'undefined', it returns 0, making this true.
    // To prevent that, first we need to check if s2 is undefined.
    return s2 !== undefined && !!s1 && !s1.localeCompare(s2, undefined, { sensitivity: "base" });
}
exports.isEqual = isEqual;
function removeSequentialDuplicates(identifier) {
    const ids = [...identifier].filter((each) => !!each);
    for (let i = 0; i < ids.length; i++) {
        while (isEqual(ids[i], ids[i - 1])) {
            ids.splice(i, 1);
        }
        while (isEqual(ids[i], ids[i - 2]) && isEqual(ids[i + 1], ids[i - 1])) {
            ids.splice(i, 2);
        }
    }
    return ids;
}
exports.removeSequentialDuplicates = removeSequentialDuplicates;
function pascalCase(identifier, removeDuplicates = true) {
    return identifier === undefined
        ? ""
        : typeof identifier === "string"
            ? pascalCase(fixLeadingNumber(deconstruct(identifier)), removeDuplicates)
            : (removeDuplicates ? [...removeSequentialDuplicates(identifier)] : identifier)
                .map((each) => capitalize(each))
                .join("");
}
exports.pascalCase = pascalCase;
function camelCase(identifier) {
    if (typeof identifier === "string") {
        return camelCase(fixLeadingNumber(deconstruct(identifier)));
    }
    switch (identifier.length) {
        case 0:
            return "";
        case 1:
            return uncapitalize(identifier[0]);
    }
    return `${uncapitalize(identifier[0])}${pascalCase(identifier.slice(1))}`;
}
exports.camelCase = camelCase;
function getPascalIdentifier(name) {
    return pascalCase(fixLeadingNumber(deconstruct(name)));
}
exports.getPascalIdentifier = getPascalIdentifier;
function escapeString(text) {
    if (text) {
        const q = JSON.stringify(text);
        return q.substr(1, q.length - 2);
    }
    return "";
}
exports.escapeString = escapeString;
/** emits c# to get the name of a property - uses nameof when it can, and uses a literal when it's an array value. */
function nameof(text) {
    if (text.indexOf("[") > -1) {
        return `$"${text.replace(/\[(.*)\]/, "[{$1}]")}"`;
    }
    return `nameof(${text})`;
}
exports.nameof = nameof;
function* getRegions(source, prefix = "#", postfix = "") {
    source = source.replace(/\r?\n|\r/g, "??");
    const rx = new RegExp(`(.*?)???(\\s*${prefix}\\s*region\\s*(.*?)\\s*${postfix})\\s*??(.*?)??(\\s*${prefix}\\s*endregion\\s*${postfix})\\s*???`, "g");
    let match;
    let finalPosition = 0;
    /* eslint-disable */
    while ((match = rx.exec(source))) {
        if (match[1]) {
            // we have text before this region.
            yield {
                name: "",
                start: "",
                content: match[1].replace(/??/g, "\n"),
                end: "",
            };
        }
        // this region
        yield {
            name: match[3],
            start: match[2],
            content: match[4].replace(/??/g, "\n"),
            end: match[5],
        };
        finalPosition = rx.lastIndex;
    }
    if (finalPosition < source.length) {
        // we have text after the last region.
        yield {
            name: "",
            start: "",
            content: source.substring(finalPosition).replace(/??/g, "\n"),
            end: "",
        };
    }
}
exports.getRegions = getRegions;
function setRegion(source, region, content, prepend = true, prefix = "#", postfix = "") {
    const result = new Array();
    const ct = new file_generator_1.Text(content).text
        .replace(/\r?\n|\r/g, "??")
        .replace(/^??*/, "")
        .replace(/??*$/, "");
    let found = false;
    for (const each of getRegions(source, prefix, postfix)) {
        if (each.name === region) {
            // found the region, replace it.
            // (this also makes sure that we only have one region by that name when replacing/deleting)
            if (!found && ct) {
                // well, only if it has content, otherwise, we're deleting it.
                result.push(each.start, ct, each.end, "??");
                found = true;
            }
        }
        else {
            result.push(each.start, each.content, each.end, "??");
        }
    }
    if (!found) {
        if (prepend) {
            result.splice(0, 0, `${prefix} region ${region} ${postfix}`, ct, `${prefix} endregion ${postfix}??`);
        }
        else {
            result.push(`${prefix} region ${region} ${postfix}`, ct, `${prefix} endregion ${postfix}??`);
        }
    }
    return result
        .join("??")
        .replace(/\r?\n|\r/g, "??")
        .replace(/^??*/, "")
        .replace(/??*$/, "")
        .replace(/??????*/g, "????")
        .replace(/??/g, "\n");
}
exports.setRegion = setRegion;
// Note: Where is this used?
function _setRegion(source, region, content, prepend = true, prefix = "#", postfix = "") {
    const ct = new file_generator_1.Text(content).text
        .replace(/\r?\n|\r/g, "??")
        .replace(/^??*/, "")
        .replace(/??*$/, "");
    source = source.replace(/\r?\n|\r/g, "??");
    const rx = new RegExp(`??(\\s*${prefix}\\s*region\\s*${region}\\s*${postfix})\\s*??.*?(??\\s*${prefix}\\s*endregion\\s*${postfix}???)`, "g");
    if (rx.test(source)) {
        if (ct.length > 0) {
            source = source.replace(rx, `??$1??${ct}$2`);
        }
        else {
            source = source.replace(rx, "");
        }
    }
    else {
        if (ct.length > 0) {
            const text = `??${prefix} region ${region} ${postfix}??${ct}??${prefix} endregion ${postfix}??`;
            source = prepend ? text + source : source + text;
        }
    }
    source = source.replace(/??????*/g, "????").replace(/??/g, "\n");
    return source;
}
exports._setRegion = _setRegion;
function selectName(nameOptions, reservedNames) {
    // we're here because the original name is in conflict.
    // so we start with the alternatives  (skip the 0th!) NOT
    for (const each of nameOptions) {
        if (!reservedNames.has(each)) {
            reservedNames.add(each);
            return each;
        }
    }
    // hmm, none of the names were suitable.
    // use the first one, and tack on a number until we have a free value
    let i = 1;
    do {
        const name = `${nameOptions[0]}${i}`;
        if (!reservedNames.has(name)) {
            reservedNames.add(name);
            return name;
        }
        i++;
    } while (i < 100);
    // after an unreasonalbe search, return something invalid
    return `InvalidPropertyName${nameOptions[0]}`;
}
exports.selectName = selectName;
//# sourceMappingURL=text-manipulation.js.map

/***/ }),

/***/ "../../libs/codegen/dist/type.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.typeOf = exports.isPrimitive = void 0;
function isPrimitive(instance) {
    switch (typeof instance) {
        case "undefined":
        case "boolean":
        case "number":
        case "string":
        case "symbol":
            return true;
        default:
            return false;
    }
}
exports.isPrimitive = isPrimitive;
function typeOf(obj) {
    if (obj === null) {
        return "null";
    }
    const t = typeof obj;
    if (t === "object") {
        if (Array.isArray(obj)) {
            return "array";
        }
        if (obj instanceof Set) {
            return "set";
        }
        if (obj instanceof Map) {
            return "map";
        }
        if (obj instanceof Date) {
            return "date";
        }
        if (obj instanceof RegExp) {
            return "regexp";
        }
    }
    return t;
}
exports.typeOf = typeOf;
//# sourceMappingURL=type.js.map

/***/ }),

/***/ "../../libs/codegen/dist/utility.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.guid = exports.copyBinaryResources = exports.copyResources = exports.applyOverrides = exports.fail = void 0;
const path_1 = __webpack_require__("path");
const aio = __importStar(__webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js"));
function getAllPropertyNames(obj) {
    const props = new Array();
    do {
        Object.getOwnPropertyNames(obj).forEach(function (prop) {
            if (props.indexOf(prop) === -1) {
                props.push(prop);
            }
        });
        /* eslint-disable */
    } while ((obj = Object.getPrototypeOf(obj)));
    return props;
}
function fail(text) {
    throw new Error(text);
}
exports.fail = fail;
function applyOverrides(content, overrides) {
    for (const [from, to] of Object.entries(overrides)) {
        content = content.replace(new RegExp(from, "g"), to);
    }
    return content;
}
exports.applyOverrides = applyOverrides;
async function copyResources(sourceFolder, fileWriter, overrides = {}, contentManipulator = async (i) => {
    return i;
}) {
    const done = new Array();
    try {
        const files = await aio.readdir(sourceFolder);
        for (const file of files) {
            const fullPath = (0, path_1.join)(sourceFolder, file);
            if (await aio.isDirectory(fullPath)) {
                done.push(copyResources(fullPath, async (f, c) => fileWriter(`${file}/${f}`, c), overrides, contentManipulator));
                continue;
            }
            if (await aio.isFile(fullPath)) {
                done.push(aio
                    .readFile(fullPath)
                    .then(contentManipulator)
                    .then(async (content) => fileWriter(file, applyOverrides(content, overrides))));
            }
        }
    }
    catch (_a) {
        // ignore failures
    }
    await Promise.all(done);
}
exports.copyResources = copyResources;
async function copyBinaryResources(sourceFolder, fileWriter) {
    const done = new Array();
    try {
        const files = await aio.readdir(sourceFolder);
        for (const file of files) {
            const fullPath = (0, path_1.join)(sourceFolder, file);
            if (await aio.isDirectory(fullPath)) {
                done.push(copyBinaryResources(fullPath, async (f, c) => fileWriter(`${file}/${f}`, c)));
                continue;
            }
            if (await aio.isFile(fullPath)) {
                done.push(aio.readBinaryFile(fullPath).then(async (content) => fileWriter(file, content)));
            }
        }
    }
    catch (_a) {
        // ignore failures
    }
    await Promise.all(done);
}
exports.copyBinaryResources = copyBinaryResources;
function quartet() {
    return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
}
function guid() {
    return (quartet() +
        quartet() +
        "-" +
        quartet() +
        "-4" +
        quartet().substr(0, 3) +
        "-" +
        quartet() +
        "-" +
        quartet() +
        quartet() +
        quartet()).toLowerCase();
}
exports.guid = guid;
//# sourceMappingURL=utility.js.map

/***/ }),

/***/ "../../libs/codegen/dist/yaml-dump/common.js":
/***/ ((module) => {

"use strict";

/**
 * This is a copy of https://github.com/nodeca/js-yaml/blob/master/lib/common.js LICENSED under MIT
 * Used by yaml-dump.ts.
 */
// eslint-disable-next-line @typescript-eslint/ban-ts-comment
// @ts-nocheck
function isNothing(subject) {
    return typeof subject === "undefined" || subject === null;
}
function isObject(subject) {
    return typeof subject === "object" && subject !== null;
}
function toArray(sequence) {
    if (Array.isArray(sequence))
        return sequence;
    else if (isNothing(sequence))
        return [];
    return [sequence];
}
function extend(target, source) {
    let index, length, key, sourceKeys;
    if (source) {
        sourceKeys = Object.keys(source);
        for (index = 0, length = sourceKeys.length; index < length; index += 1) {
            key = sourceKeys[index];
            target[key] = source[key];
        }
    }
    return target;
}
function repeat(string, count) {
    let result = "", cycle;
    for (cycle = 0; cycle < count; cycle += 1) {
        result += string;
    }
    return result;
}
function isNegativeZero(number) {
    return number === 0 && Number.NEGATIVE_INFINITY === 1 / number;
}
module.exports.isNothing = isNothing;
module.exports.isObject = isObject;
module.exports.toArray = toArray;
module.exports.repeat = repeat;
module.exports.isNegativeZero = isNegativeZero;
module.exports.extend = extend;
//# sourceMappingURL=common.js.map

/***/ }),

/***/ "../../libs/codegen/dist/yaml-dump/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/codegen/dist/yaml-dump/yaml-dump.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/codegen/dist/yaml-dump/yaml-dump.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

/**
 * This is a copy of https://github.com/nodeca/js-yaml/blob/master/lib/dumper.js LICENSED under MIT
 *
 * It is modified to improve performance when finding duplicate refs.
 * Instead of using an array with indexOf resulting in O(n2) it was changed to use es6 Set.
 */
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.dump = void 0;
/* eslint-disable prefer-const */
// eslint-disable-next-line @typescript-eslint/ban-ts-comment
// @ts-nocheck
/*eslint-disable no-use-before-define*/
const common_1 = __importDefault(__webpack_require__("../../libs/codegen/dist/yaml-dump/common.js"));
const { DEFAULT_SCHEMA, YAMLException } = __webpack_require__("../../../common/temp/node_modules/.pnpm/js-yaml@4.0.0/node_modules/js-yaml/index.js");
const _toString = Object.prototype.toString;
const _hasOwnProperty = Object.prototype.hasOwnProperty;
const CHAR_BOM = 0xfeff;
const CHAR_TAB = 0x09; /* Tab */
const CHAR_LINE_FEED = 0x0a; /* LF */
const CHAR_CARRIAGE_RETURN = 0x0d; /* CR */
const CHAR_SPACE = 0x20; /* Space */
const CHAR_EXCLAMATION = 0x21; /* ! */
const CHAR_DOUBLE_QUOTE = 0x22; /* " */
const CHAR_SHARP = 0x23; /* # */
const CHAR_PERCENT = 0x25; /* % */
const CHAR_AMPERSAND = 0x26; /* & */
const CHAR_SINGLE_QUOTE = 0x27; /* ' */
const CHAR_ASTERISK = 0x2a; /* * */
const CHAR_COMMA = 0x2c; /* , */
const CHAR_MINUS = 0x2d; /* - */
const CHAR_COLON = 0x3a; /* : */
const CHAR_EQUALS = 0x3d; /* = */
const CHAR_GREATER_THAN = 0x3e; /* > */
const CHAR_QUESTION = 0x3f; /* ? */
const CHAR_COMMERCIAL_AT = 0x40; /* @ */
const CHAR_LEFT_SQUARE_BRACKET = 0x5b; /* [ */
const CHAR_RIGHT_SQUARE_BRACKET = 0x5d; /* ] */
const CHAR_GRAVE_ACCENT = 0x60; /* ` */
const CHAR_LEFT_CURLY_BRACKET = 0x7b; /* { */
const CHAR_VERTICAL_LINE = 0x7c; /* | */
const CHAR_RIGHT_CURLY_BRACKET = 0x7d; /* } */
const ESCAPE_SEQUENCES = {};
ESCAPE_SEQUENCES[0x00] = "\\0";
ESCAPE_SEQUENCES[0x07] = "\\a";
ESCAPE_SEQUENCES[0x08] = "\\b";
ESCAPE_SEQUENCES[0x09] = "\\t";
ESCAPE_SEQUENCES[0x0a] = "\\n";
ESCAPE_SEQUENCES[0x0b] = "\\v";
ESCAPE_SEQUENCES[0x0c] = "\\f";
ESCAPE_SEQUENCES[0x0d] = "\\r";
ESCAPE_SEQUENCES[0x1b] = "\\e";
ESCAPE_SEQUENCES[0x22] = '\\"';
ESCAPE_SEQUENCES[0x5c] = "\\\\";
ESCAPE_SEQUENCES[0x85] = "\\N";
ESCAPE_SEQUENCES[0xa0] = "\\_";
ESCAPE_SEQUENCES[0x2028] = "\\L";
ESCAPE_SEQUENCES[0x2029] = "\\P";
const DEPRECATED_BOOLEANS_SYNTAX = [
    "y",
    "Y",
    "yes",
    "Yes",
    "YES",
    "on",
    "On",
    "ON",
    "n",
    "N",
    "no",
    "No",
    "NO",
    "off",
    "Off",
    "OFF",
];
const DEPRECATED_BASE60_SYNTAX = /^[-+]?[0-9_]+(?::[0-9_]+)+(?:\.[0-9_]*)?$/;
function compileStyleMap(schema, map) {
    let result, keys, index, length, tag, style, type;
    if (map === null)
        return {};
    result = {};
    keys = Object.keys(map);
    for (index = 0, length = keys.length; index < length; index += 1) {
        tag = keys[index];
        style = String(map[tag]);
        if (tag.slice(0, 2) === "!!") {
            tag = "tag:yaml.org,2002:" + tag.slice(2);
        }
        type = schema.compiledTypeMap["fallback"][tag];
        if (type && _hasOwnProperty.call(type.styleAliases, style)) {
            style = type.styleAliases[style];
        }
        result[tag] = style;
    }
    return result;
}
function encodeHex(character) {
    let string, handle, length;
    string = character.toString(16).toUpperCase();
    if (character <= 0xff) {
        handle = "x";
        length = 2;
    }
    else if (character <= 0xffff) {
        handle = "u";
        length = 4;
    }
    else if (character <= 0xffffffff) {
        handle = "U";
        length = 8;
    }
    else {
        throw new YAMLException("code point within a string may not be greater than 0xFFFFFFFF");
    }
    return "\\" + handle + common_1.default.repeat("0", length - string.length) + string;
}
const QUOTING_TYPE_SINGLE = 1, QUOTING_TYPE_DOUBLE = 2;
function State(options) {
    this.schema = options["schema"] || DEFAULT_SCHEMA;
    this.indent = Math.max(1, options["indent"] || 2);
    this.noArrayIndent = options["noArrayIndent"] || false;
    this.skipInvalid = options["skipInvalid"] || false;
    this.flowLevel = common_1.default.isNothing(options["flowLevel"]) ? -1 : options["flowLevel"];
    this.styleMap = compileStyleMap(this.schema, options["styles"] || null);
    this.sortKeys = options["sortKeys"] || false;
    this.lineWidth = options["lineWidth"] || 80;
    this.noRefs = options["noRefs"] || false;
    this.noCompatMode = options["noCompatMode"] || false;
    this.condenseFlow = options["condenseFlow"] || false;
    this.quotingType = options["quotingType"] === '"' ? QUOTING_TYPE_DOUBLE : QUOTING_TYPE_SINGLE;
    this.forceQuotes = options["forceQuotes"] || false;
    this.replacer = typeof options["replacer"] === "function" ? options["replacer"] : null;
    this.implicitTypes = this.schema.compiledImplicit;
    this.explicitTypes = this.schema.compiledExplicit;
    this.tag = null;
    this.result = "";
    this.duplicates = [];
    this.usedDuplicates = null;
}
// Indents every line in a string. Empty lines (\n only) are not indented.
function indentString(string, spaces) {
    let ind = common_1.default.repeat(" ", spaces), position = 0, next = -1, result = "", line, length = string.length;
    while (position < length) {
        next = string.indexOf("\n", position);
        if (next === -1) {
            line = string.slice(position);
            position = length;
        }
        else {
            line = string.slice(position, next + 1);
            position = next + 1;
        }
        if (line.length && line !== "\n")
            result += ind;
        result += line;
    }
    return result;
}
function generateNextLine(state, level) {
    return "\n" + common_1.default.repeat(" ", state.indent * level);
}
function testImplicitResolving(state, str) {
    let index, length, type;
    for (index = 0, length = state.implicitTypes.length; index < length; index += 1) {
        type = state.implicitTypes[index];
        if (type.resolve(str)) {
            return true;
        }
    }
    return false;
}
// [33] s-white ::= s-space | s-tab
function isWhitespace(c) {
    return c === CHAR_SPACE || c === CHAR_TAB;
}
// Returns true if the character can be printed without escaping.
// From YAML 1.2: "any allowed characters known to be non-printable
// should also be escaped. [However,] This isn???t mandatory"
// Derived from nb-char - \t - #x85 - #xA0 - #x2028 - #x2029.
function isPrintable(c) {
    return ((0x00020 <= c && c <= 0x00007e) ||
        (0x000a1 <= c && c <= 0x00d7ff && c !== 0x2028 && c !== 0x2029) ||
        (0x0e000 <= c && c <= 0x00fffd && c !== CHAR_BOM) ||
        (0x10000 <= c && c <= 0x10ffff));
}
// [34] ns-char ::= nb-char - s-white
// [27] nb-char ::= c-printable - b-char - c-byte-order-mark
// [26] b-char  ::= b-line-feed | b-carriage-return
// Including s-white (for some reason, examples doesn't match specs in this aspect)
// ns-char ::= c-printable - b-line-feed - b-carriage-return - c-byte-order-mark
function isNsCharOrWhitespace(c) {
    return (isPrintable(c) &&
        c !== CHAR_BOM &&
        // - b-char
        c !== CHAR_CARRIAGE_RETURN &&
        c !== CHAR_LINE_FEED);
}
// [127]  ns-plain-safe(c) ::= c = flow-out  ??? ns-plain-safe-out
//                             c = flow-in   ??? ns-plain-safe-in
//                             c = block-key ??? ns-plain-safe-out
//                             c = flow-key  ??? ns-plain-safe-in
// [128] ns-plain-safe-out ::= ns-char
// [129]  ns-plain-safe-in ::= ns-char - c-flow-indicator
// [130]  ns-plain-char(c) ::=  ( ns-plain-safe(c) - ???:??? - ???#??? )
//                            | ( /* An ns-char preceding */ ???#??? )
//                            | ( ???:??? /* Followed by an ns-plain-safe(c) */ )
function isPlainSafe(c, prev, inblock) {
    const cIsNsCharOrWhitespace = isNsCharOrWhitespace(c);
    const cIsNsChar = cIsNsCharOrWhitespace && !isWhitespace(c);
    return (
    // ns-plain-safe
    ((inblock // c = flow-in
        ? cIsNsCharOrWhitespace
        : cIsNsCharOrWhitespace &&
            // - c-flow-indicator
            c !== CHAR_COMMA &&
            c !== CHAR_LEFT_SQUARE_BRACKET &&
            c !== CHAR_RIGHT_SQUARE_BRACKET &&
            c !== CHAR_LEFT_CURLY_BRACKET &&
            c !== CHAR_RIGHT_CURLY_BRACKET) &&
        // ns-plain-char
        c !== CHAR_SHARP && // false on '#'
        !(prev === CHAR_COLON && !cIsNsChar)) || // false on ': '
        (isNsCharOrWhitespace(prev) && !isWhitespace(prev) && c === CHAR_SHARP) || // change to true on '[^ ]#'
        (prev === CHAR_COLON && cIsNsChar)); // change to true on ':[^ ]'
}
// Simplified test for values allowed as the first character in plain style.
function isPlainSafeFirst(c) {
    // Uses a subset of ns-char - c-indicator
    // where ns-char = nb-char - s-white.
    // No support of ( ( ??????? | ???:??? | ???-??? ) /* Followed by an ns-plain-safe(c)) */ ) part
    return (isPrintable(c) &&
        c !== CHAR_BOM &&
        !isWhitespace(c) && // - s-white
        // - (c-indicator ::=
        // ???-??? | ??????? | ???:??? | ???,??? | ???[??? | ???]??? | ???{??? | ???}???
        c !== CHAR_MINUS &&
        c !== CHAR_QUESTION &&
        c !== CHAR_COLON &&
        c !== CHAR_COMMA &&
        c !== CHAR_LEFT_SQUARE_BRACKET &&
        c !== CHAR_RIGHT_SQUARE_BRACKET &&
        c !== CHAR_LEFT_CURLY_BRACKET &&
        c !== CHAR_RIGHT_CURLY_BRACKET &&
        // | ???#??? | ???&??? | ???*??? | ???!??? | ???|??? | ???=??? | ???>??? | ???'??? | ???"???
        c !== CHAR_SHARP &&
        c !== CHAR_AMPERSAND &&
        c !== CHAR_ASTERISK &&
        c !== CHAR_EXCLAMATION &&
        c !== CHAR_VERTICAL_LINE &&
        c !== CHAR_EQUALS &&
        c !== CHAR_GREATER_THAN &&
        c !== CHAR_SINGLE_QUOTE &&
        c !== CHAR_DOUBLE_QUOTE &&
        // | ???%??? | ???@??? | ???`???)
        c !== CHAR_PERCENT &&
        c !== CHAR_COMMERCIAL_AT &&
        c !== CHAR_GRAVE_ACCENT);
}
// Simplified test for values allowed as the last character in plain style.
function isPlainSafeLast(c) {
    // just not whitespace or colon, it will be checked to be plain character later
    return !isWhitespace(c) && c !== CHAR_COLON;
}
// Same as 'string'.codePointAt(pos), but works in older browsers.
function codePointAt(string, pos) {
    let first = string.charCodeAt(pos), second;
    if (first >= 0xd800 && first <= 0xdbff && pos + 1 < string.length) {
        second = string.charCodeAt(pos + 1);
        if (second >= 0xdc00 && second <= 0xdfff) {
            // https://mathiasbynens.be/notes/javascript-encoding#surrogate-formulae
            return (first - 0xd800) * 0x400 + second - 0xdc00 + 0x10000;
        }
    }
    return first;
}
// Determines whether block indentation indicator is required.
function needIndentIndicator(string) {
    const leadingSpaceRe = /^\n* /;
    return leadingSpaceRe.test(string);
}
const STYLE_PLAIN = 1, STYLE_SINGLE = 2, STYLE_LITERAL = 3, STYLE_FOLDED = 4, STYLE_DOUBLE = 5;
// Determines which scalar styles are possible and returns the preferred style.
// lineWidth = -1 => no limit.
// Pre-conditions: str.length > 0.
// Post-conditions:
//    STYLE_PLAIN or STYLE_SINGLE => no \n are in the string.
//    STYLE_LITERAL => no lines are suitable for folding (or lineWidth is -1).
//    STYLE_FOLDED => a line > lineWidth and can be folded (and lineWidth != -1).
function chooseScalarStyle(string, singleLineOnly, indentPerLevel, lineWidth, testAmbiguousType, quotingType, forceQuotes, inblock) {
    let i;
    let char = 0;
    let prevChar = null;
    let hasLineBreak = false;
    let hasFoldableLine = false; // only checked if shouldTrackWidth
    const shouldTrackWidth = lineWidth !== -1;
    let previousLineBreak = -1; // count the first line correctly
    let plain = isPlainSafeFirst(codePointAt(string, 0)) && isPlainSafeLast(codePointAt(string, string.length - 1));
    if (singleLineOnly || forceQuotes) {
        // Case: no block styles.
        // Check for disallowed characters to rule out plain and single.
        for (i = 0; i < string.length; char >= 0x10000 ? (i += 2) : i++) {
            char = codePointAt(string, i);
            if (!isPrintable(char)) {
                return STYLE_DOUBLE;
            }
            plain = plain && isPlainSafe(char, prevChar, inblock);
            prevChar = char;
        }
    }
    else {
        // Case: block styles permitted.
        for (i = 0; i < string.length; char >= 0x10000 ? (i += 2) : i++) {
            char = codePointAt(string, i);
            if (char === CHAR_LINE_FEED) {
                hasLineBreak = true;
                // Check if any line can be folded.
                if (shouldTrackWidth) {
                    hasFoldableLine =
                        hasFoldableLine ||
                            // Foldable line = too long, and not more-indented.
                            (i - previousLineBreak - 1 > lineWidth && string[previousLineBreak + 1] !== " ");
                    previousLineBreak = i;
                }
            }
            else if (!isPrintable(char)) {
                return STYLE_DOUBLE;
            }
            plain = plain && isPlainSafe(char, prevChar, inblock);
            prevChar = char;
        }
        // in case the end is missing a \n
        hasFoldableLine =
            hasFoldableLine ||
                (shouldTrackWidth && i - previousLineBreak - 1 > lineWidth && string[previousLineBreak + 1] !== " ");
    }
    // Although every style can represent \n without escaping, prefer block styles
    // for multiline, since they're more readable and they don't add empty lines.
    // Also prefer folding a super-long line.
    if (!hasLineBreak && !hasFoldableLine) {
        // Strings interpretable as another type have to be quoted;
        // e.g. the string 'true' vs. the boolean true.
        if (plain && !forceQuotes && !testAmbiguousType(string)) {
            return STYLE_PLAIN;
        }
        return quotingType === QUOTING_TYPE_DOUBLE ? STYLE_DOUBLE : STYLE_SINGLE;
    }
    // Edge case: block indentation indicator can only have one digit.
    if (indentPerLevel > 9 && needIndentIndicator(string)) {
        return STYLE_DOUBLE;
    }
    // At this point we know block styles are valid.
    // Prefer literal style unless we want to fold.
    if (!forceQuotes) {
        return hasFoldableLine ? STYLE_FOLDED : STYLE_LITERAL;
    }
    return quotingType === QUOTING_TYPE_DOUBLE ? STYLE_DOUBLE : STYLE_SINGLE;
}
// Note: line breaking/folding is implemented for only the folded style.
// NB. We drop the last trailing newline (if any) of a returned block scalar
//  since the dumper adds its own newline. This always works:
//    ??? No ending newline => unaffected; already using strip "-" chomping.
//    ??? Ending newline    => removed then restored.
//  Importantly, this keeps the "+" chomp indicator from gaining an extra line.
function writeScalar(state, string, level, iskey, inblock) {
    state.dump = (function () {
        if (string.length === 0) {
            return state.quotingType === QUOTING_TYPE_DOUBLE ? '""' : "''";
        }
        if (!state.noCompatMode) {
            if (DEPRECATED_BOOLEANS_SYNTAX.indexOf(string) !== -1 || DEPRECATED_BASE60_SYNTAX.test(string)) {
                return state.quotingType === QUOTING_TYPE_DOUBLE ? '"' + string + '"' : "'" + string + "'";
            }
        }
        const indent = state.indent * Math.max(1, level); // no 0-indent scalars
        // As indentation gets deeper, let the width decrease monotonically
        // to the lower bound min(state.lineWidth, 40).
        // Note that this implies
        //  state.lineWidth ??? 40 + state.indent: width is fixed at the lower bound.
        //  state.lineWidth > 40 + state.indent: width decreases until the lower bound.
        // This behaves better than a constant minimum width which disallows narrower options,
        // or an indent threshold which causes the width to suddenly increase.
        const lineWidth = state.lineWidth === -1 ? -1 : Math.max(Math.min(state.lineWidth, 40), state.lineWidth - indent);
        // Without knowing if keys are implicit/explicit, assume implicit for safety.
        const singleLineOnly = iskey ||
            // No block styles in flow mode.
            (state.flowLevel > -1 && level >= state.flowLevel);
        function testAmbiguity(string) {
            return testImplicitResolving(state, string);
        }
        switch (chooseScalarStyle(string, singleLineOnly, state.indent, lineWidth, testAmbiguity, state.quotingType, state.forceQuotes && !iskey, inblock)) {
            case STYLE_PLAIN:
                return string;
            case STYLE_SINGLE:
                return "'" + string.replace(/'/g, "''") + "'";
            case STYLE_LITERAL:
                return "|" + blockHeader(string, state.indent) + dropEndingNewline(indentString(string, indent));
            case STYLE_FOLDED:
                return (">" +
                    blockHeader(string, state.indent) +
                    dropEndingNewline(indentString(foldString(string, lineWidth), indent)));
            case STYLE_DOUBLE:
                return '"' + escapeString(string, lineWidth) + '"';
            default:
                throw new YAMLException("impossible error: invalid scalar style");
        }
    })();
}
// Pre-conditions: string is valid for a block scalar, 1 <= indentPerLevel <= 9.
function blockHeader(string, indentPerLevel) {
    const indentIndicator = needIndentIndicator(string) ? String(indentPerLevel) : "";
    // note the special case: the string '\n' counts as a "trailing" empty line.
    const clip = string[string.length - 1] === "\n";
    const keep = clip && (string[string.length - 2] === "\n" || string === "\n");
    const chomp = keep ? "+" : clip ? "" : "-";
    return indentIndicator + chomp + "\n";
}
// (See the note for writeScalar.)
function dropEndingNewline(string) {
    return string[string.length - 1] === "\n" ? string.slice(0, -1) : string;
}
// Note: a long line without a suitable break point will exceed the width limit.
// Pre-conditions: every char in str isPrintable, str.length > 0, width > 0.
function foldString(string, width) {
    // In folded style, $k$ consecutive newlines output as $k+1$ newlines???
    // unless they're before or after a more-indented line, or at the very
    // beginning or end, in which case $k$ maps to $k$.
    // Therefore, parse each chunk as newline(s) followed by a content line.
    const lineRe = /(\n+)([^\n]*)/g;
    // first line (possibly an empty line)
    let result = (function () {
        let nextLF = string.indexOf("\n");
        nextLF = nextLF !== -1 ? nextLF : string.length;
        lineRe.lastIndex = nextLF;
        return foldLine(string.slice(0, nextLF), width);
    })();
    // If we haven't reached the first content line yet, don't add an extra \n.
    let prevMoreIndented = string[0] === "\n" || string[0] === " ";
    let moreIndented;
    // rest of the lines
    let match;
    while ((match = lineRe.exec(string))) {
        const prefix = match[1], line = match[2];
        moreIndented = line[0] === " ";
        result += prefix + (!prevMoreIndented && !moreIndented && line !== "" ? "\n" : "") + foldLine(line, width);
        prevMoreIndented = moreIndented;
    }
    return result;
}
// Greedy line breaking.
// Picks the longest line under the limit each time,
// otherwise settles for the shortest line over the limit.
// NB. More-indented lines *cannot* be folded, as that would add an extra \n.
function foldLine(line, width) {
    if (line === "" || line[0] === " ")
        return line;
    // Since a more-indented line adds a \n, breaks can't be followed by a space.
    const breakRe = / [^ ]/g; // note: the match index will always be <= length-2.
    let match;
    // start is an inclusive index. end, curr, and next are exclusive.
    let start = 0, end, curr = 0, next = 0;
    let result = "";
    // Invariants: 0 <= start <= length-1.
    //   0 <= curr <= next <= max(0, length-2). curr - start <= width.
    // Inside the loop:
    //   A match implies length >= 2, so curr and next are <= length-2.
    while ((match = breakRe.exec(line))) {
        next = match.index;
        // maintain invariant: curr - start <= width
        if (next - start > width) {
            end = curr > start ? curr : next; // derive end <= length-2
            result += "\n" + line.slice(start, end);
            // skip the space that was output as \n
            start = end + 1; // derive start <= length-1
        }
        curr = next;
    }
    // By the invariants, start <= length-1, so there is something left over.
    // It is either the whole string or a part starting from non-whitespace.
    result += "\n";
    // Insert a break if the remainder is too long and there is a break available.
    if (line.length - start > width && curr > start) {
        result += line.slice(start, curr) + "\n" + line.slice(curr + 1);
    }
    else {
        result += line.slice(start);
    }
    return result.slice(1); // drop extra \n joiner
}
// Escapes a double-quoted string.
function escapeString(string) {
    let result = "";
    let char = 0;
    let escapeSeq;
    for (let i = 0; i < string.length; char >= 0x10000 ? (i += 2) : i++) {
        char = codePointAt(string, i);
        escapeSeq = ESCAPE_SEQUENCES[char];
        if (!escapeSeq && isPrintable(char)) {
            result += string[i];
            if (char >= 0x10000)
                result += string[i + 1];
        }
        else {
            result += escapeSeq || encodeHex(char);
        }
    }
    return result;
}
function writeFlowSequence(state, level, object) {
    let _result = "", _tag = state.tag, index, length, value;
    for (index = 0, length = object.length; index < length; index += 1) {
        value = object[index];
        if (state.replacer) {
            value = state.replacer.call(object, String(index), value);
        }
        // Write only valid elements, put null instead of invalid elements.
        if (writeNode(state, level, value, false, false) ||
            (typeof value === "undefined" && writeNode(state, level, null, false, false))) {
            if (_result !== "")
                _result += "," + (!state.condenseFlow ? " " : "");
            _result += state.dump;
        }
    }
    state.tag = _tag;
    state.dump = "[" + _result + "]";
}
function writeBlockSequence(state, level, object, compact) {
    let _result = "", _tag = state.tag, index, length, value;
    for (index = 0, length = object.length; index < length; index += 1) {
        value = object[index];
        if (state.replacer) {
            value = state.replacer.call(object, String(index), value);
        }
        // Write only valid elements, put null instead of invalid elements.
        if (writeNode(state, level + 1, value, true, true, false, true) ||
            (typeof value === "undefined" && writeNode(state, level + 1, null, true, true, false, true))) {
            if (!compact || _result !== "") {
                _result += generateNextLine(state, level);
            }
            if (state.dump && CHAR_LINE_FEED === state.dump.charCodeAt(0)) {
                _result += "-";
            }
            else {
                _result += "- ";
            }
            _result += state.dump;
        }
    }
    state.tag = _tag;
    state.dump = _result || "[]"; // Empty sequence if no valid values.
}
function writeFlowMapping(state, level, object) {
    let _result = "", _tag = state.tag, objectKeyList = Object.keys(object), index, length, objectKey, objectValue, pairBuffer;
    for (index = 0, length = objectKeyList.length; index < length; index += 1) {
        pairBuffer = "";
        if (_result !== "")
            pairBuffer += ", ";
        if (state.condenseFlow)
            pairBuffer += '"';
        objectKey = objectKeyList[index];
        objectValue = object[objectKey];
        if (state.replacer) {
            objectValue = state.replacer.call(object, objectKey, objectValue);
        }
        if (!writeNode(state, level, objectKey, false, false)) {
            continue; // Skip this pair because of invalid key;
        }
        if (state.dump.length > 1024)
            pairBuffer += "? ";
        pairBuffer += state.dump + (state.condenseFlow ? '"' : "") + ":" + (state.condenseFlow ? "" : " ");
        if (!writeNode(state, level, objectValue, false, false)) {
            continue; // Skip this pair because of invalid value.
        }
        pairBuffer += state.dump;
        // Both key and value are valid.
        _result += pairBuffer;
    }
    state.tag = _tag;
    state.dump = "{" + _result + "}";
}
function writeBlockMapping(state, level, object, compact) {
    let _result = "", _tag = state.tag, objectKeyList = Object.keys(object), index, length, objectKey, objectValue, explicitPair, pairBuffer;
    // Allow sorting keys so that the output file is deterministic
    if (state.sortKeys === true) {
        // Default sorting
        objectKeyList.sort();
    }
    else if (typeof state.sortKeys === "function") {
        // Custom sort function
        objectKeyList.sort(state.sortKeys);
    }
    else if (state.sortKeys) {
        // Something is wrong
        throw new YAMLException("sortKeys must be a boolean or a function");
    }
    for (index = 0, length = objectKeyList.length; index < length; index += 1) {
        pairBuffer = "";
        if (!compact || _result !== "") {
            pairBuffer += generateNextLine(state, level);
        }
        objectKey = objectKeyList[index];
        objectValue = object[objectKey];
        if (state.replacer) {
            objectValue = state.replacer.call(object, objectKey, objectValue);
        }
        if (!writeNode(state, level + 1, objectKey, true, true, true)) {
            continue; // Skip this pair because of invalid key.
        }
        explicitPair = (state.tag !== null && state.tag !== "?") || (state.dump && state.dump.length > 1024);
        if (explicitPair) {
            if (state.dump && CHAR_LINE_FEED === state.dump.charCodeAt(0)) {
                pairBuffer += "?";
            }
            else {
                pairBuffer += "? ";
            }
        }
        pairBuffer += state.dump;
        if (explicitPair) {
            pairBuffer += generateNextLine(state, level);
        }
        if (!writeNode(state, level + 1, objectValue, true, explicitPair)) {
            continue; // Skip this pair because of invalid value.
        }
        if (state.dump && CHAR_LINE_FEED === state.dump.charCodeAt(0)) {
            pairBuffer += ":";
        }
        else {
            pairBuffer += ": ";
        }
        pairBuffer += state.dump;
        // Both key and value are valid.
        _result += pairBuffer;
    }
    state.tag = _tag;
    state.dump = _result || "{}"; // Empty mapping if no valid pairs.
}
function detectType(state, object, explicit) {
    let _result, typeList, index, length, type, style;
    typeList = explicit ? state.explicitTypes : state.implicitTypes;
    for (index = 0, length = typeList.length; index < length; index += 1) {
        type = typeList[index];
        if ((type.instanceOf || type.predicate) &&
            (!type.instanceOf || (typeof object === "object" && object instanceof type.instanceOf)) &&
            (!type.predicate || type.predicate(object))) {
            if (explicit) {
                if (type.multi && type.representName) {
                    state.tag = type.representName(object);
                }
                else {
                    state.tag = type.tag;
                }
            }
            else {
                state.tag = "?";
            }
            if (type.represent) {
                style = state.styleMap[type.tag] || type.defaultStyle;
                if (_toString.call(type.represent) === "[object Function]") {
                    _result = type.represent(object, style);
                }
                else if (_hasOwnProperty.call(type.represent, style)) {
                    _result = type.represent[style](object, style);
                }
                else {
                    throw new YAMLException("!<" + type.tag + '> tag resolver accepts not "' + style + '" style');
                }
                state.dump = _result;
            }
            return true;
        }
    }
    return false;
}
// Serializes `object` and writes it to global `result`.
// Returns true on success, or false on invalid object.
//
function writeNode(state, level, object, block, compact, iskey, isblockseq) {
    state.tag = null;
    state.dump = object;
    if (!detectType(state, object, false)) {
        detectType(state, object, true);
    }
    const type = _toString.call(state.dump);
    const inblock = block;
    let tagStr;
    if (block) {
        block = state.flowLevel < 0 || state.flowLevel > level;
    }
    let objectOrArray = type === "[object Object]" || type === "[object Array]", duplicateIndex, duplicate;
    if (objectOrArray) {
        duplicateIndex = state.duplicates.indexOf(object);
        duplicate = duplicateIndex !== -1;
    }
    if ((state.tag !== null && state.tag !== "?") || duplicate || (state.indent !== 2 && level > 0)) {
        compact = false;
    }
    if (duplicate && state.usedDuplicates[duplicateIndex]) {
        state.dump = "*ref_" + duplicateIndex;
    }
    else {
        if (objectOrArray && duplicate && !state.usedDuplicates[duplicateIndex]) {
            state.usedDuplicates[duplicateIndex] = true;
        }
        if (type === "[object Object]") {
            if (block && Object.keys(state.dump).length !== 0) {
                writeBlockMapping(state, level, state.dump, compact);
                if (duplicate) {
                    state.dump = "&ref_" + duplicateIndex + state.dump;
                }
            }
            else {
                writeFlowMapping(state, level, state.dump);
                if (duplicate) {
                    state.dump = "&ref_" + duplicateIndex + " " + state.dump;
                }
            }
        }
        else if (type === "[object Array]") {
            if (block && state.dump.length !== 0) {
                if (state.noArrayIndent && !isblockseq && level > 0) {
                    writeBlockSequence(state, level - 1, state.dump, compact);
                }
                else {
                    writeBlockSequence(state, level, state.dump, compact);
                }
                if (duplicate) {
                    state.dump = "&ref_" + duplicateIndex + state.dump;
                }
            }
            else {
                writeFlowSequence(state, level, state.dump);
                if (duplicate) {
                    state.dump = "&ref_" + duplicateIndex + " " + state.dump;
                }
            }
        }
        else if (type === "[object String]") {
            if (state.tag !== "?") {
                writeScalar(state, state.dump, level, iskey, inblock);
            }
        }
        else if (type === "[object Undefined]") {
            return false;
        }
        else {
            if (state.skipInvalid)
                return false;
            throw new YAMLException("unacceptable kind of an object to dump " + type);
        }
        if (state.tag !== null && state.tag !== "?") {
            // Need to encode all characters except those allowed by the spec:
            //
            // [35] ns-dec-digit    ::=  [#x30-#x39] /* 0-9 */
            // [36] ns-hex-digit    ::=  ns-dec-digit
            //                         | [#x41-#x46] /* A-F */ | [#x61-#x66] /* a-f */
            // [37] ns-ascii-letter ::=  [#x41-#x5A] /* A-Z */ | [#x61-#x7A] /* a-z */
            // [38] ns-word-char    ::=  ns-dec-digit | ns-ascii-letter | ???-???
            // [39] ns-uri-char     ::=  ???%??? ns-hex-digit ns-hex-digit | ns-word-char | ???#???
            //                         | ???;??? | ???/??? | ??????? | ???:??? | ???@??? | ???&??? | ???=??? | ???+??? | ???$??? | ???,???
            //                         | ???_??? | ???.??? | ???!??? | ???~??? | ???*??? | ???'??? | ???(??? | ???)??? | ???[??? | ???]???
            //
            // Also need to encode '!' because it has special meaning (end of tag prefix).
            //
            tagStr = encodeURI(state.tag[0] === "!" ? state.tag.slice(1) : state.tag).replace(/!/g, "%21");
            if (state.tag[0] === "!") {
                tagStr = "!" + tagStr;
            }
            else if (tagStr.slice(0, 18) === "tag:yaml.org,2002:") {
                tagStr = "!!" + tagStr.slice(18);
            }
            else {
                tagStr = "!<" + tagStr + ">";
            }
            state.dump = tagStr + " " + state.dump;
        }
    }
    return true;
}
function getDuplicateReferences(object, state) {
    let objects = new Set(), duplicatesIndexes = new Set(), index, length;
    inspectNode(object, objects, duplicatesIndexes);
    state.duplicates = [...duplicatesIndexes];
    state.usedDuplicates = new Array(length);
}
function inspectNode(object, objects, duplicatesIndexes) {
    let objectKeyList, index, length;
    if (object !== null && typeof object === "object") {
        if (objects.has(object)) {
            if (!duplicatesIndexes.has(object)) {
                duplicatesIndexes.add(object);
            }
        }
        else {
            objects.add(object);
            if (Array.isArray(object)) {
                for (index = 0, length = object.length; index < length; index += 1) {
                    inspectNode(object[index], objects, duplicatesIndexes);
                }
            }
            else {
                objectKeyList = Object.keys(object);
                for (index = 0, length = objectKeyList.length; index < length; index += 1) {
                    inspectNode(object[objectKeyList[index]], objects, duplicatesIndexes);
                }
            }
        }
    }
}
function dump(input, options) {
    options = options || {};
    const state = new State(options);
    if (!state.noRefs)
        getDuplicateReferences(input, state);
    let value = input;
    if (state.replacer) {
        value = state.replacer.call({ "": value }, "", value);
    }
    if (writeNode(state, 0, value, true, true))
        return state.dump + "\n";
    return "";
}
exports.dump = dump;
//# sourceMappingURL=yaml-dump.js.map

/***/ }),

/***/ "../../libs/codegen/dist/yaml.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.serialize = exports.deserialize = void 0;
const js_yaml_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/js-yaml@4.0.0/node_modules/js-yaml/index.js");
const yaml_dump_1 = __webpack_require__("../../libs/codegen/dist/yaml-dump/index.js");
const propertyPriority = [
    "info",
    "$key",
    "booleans",
    "numbers",
    "chars",
    "strings",
    "choices",
    "sealedChoices",
    "constants",
    "dictionaries",
    "compounds",
    "name",
    "schemas",
    "type",
    "format",
    "schema",
    "operationId",
    "path",
    "method",
    "description",
    "default",
];
const propertyNegativePriority = [
    "objects",
    "arrays",
    "request",
    "responses",
    "exceptions",
    "callbacks",
    "http",
    "commands",
    "operations",
    "extensions",
    "details",
    "language",
    "protocol",
];
function sortWithPriorty(a, b) {
    if (a == b) {
        return 0;
    }
    const ia = propertyPriority.indexOf(a);
    const ib = propertyPriority.indexOf(b);
    const na = propertyNegativePriority.indexOf(a);
    const nb = propertyNegativePriority.indexOf(b);
    const dota = `${a}`.startsWith(".");
    const dotb = `${b}`.startsWith(".");
    if (dota) {
        if (!dotb) {
            return 1;
        }
    }
    else {
        if (dotb) {
            return -1;
        }
    }
    if (na > -1) {
        if (nb > -1) {
            return na - nb;
        }
        return 1;
    }
    if (nb > -1) {
        return -1;
    }
    if (ia != -1) {
        return ib != -1 ? ia - ib : -1;
    }
    return ib != -1 || a > b ? 1 : a < b ? -1 : 0;
}
function deserialize(text, filename, schema = js_yaml_1.DEFAULT_SCHEMA) {
    return (0, js_yaml_1.load)(text, {
        schema,
        filename,
    });
}
exports.deserialize = deserialize;
function serialize(model, schemaOrOptions = js_yaml_1.DEFAULT_SCHEMA) {
    const options = schemaOrOptions instanceof js_yaml_1.Schema
        ? { schema: schemaOrOptions, sortKeys: true }
        : { schema: js_yaml_1.DEFAULT_SCHEMA, sortKeys: true, ...schemaOrOptions };
    return (0, yaml_dump_1.dump)(model, {
        schema: options.schema,
        sortKeys: options.sortKeys && sortWithPriorty,
        skipInvalid: true,
        lineWidth: 240,
    });
    // .replace(/\s*\w*: {}/g, '')
    // .replace(/\s*\w*: \[\]/g, '')
    // .replace(/(\s*- \$key:)/g, '\n$1')
    // .replace(/-\n\s+version/g, '- version');
    // .replace(/(\s*)(language:)/g, '\n$1## ----------------------------------------------------------------------$1$2')
    // replace(/([^:]\n)(\s*-)/g, '$1\n$2')
    //.replace(/(\s*language:)/g, '\n$1');
}
exports.serialize = serialize;
//# sourceMappingURL=yaml.js.map

/***/ }),

/***/ "../../libs/common/dist/exceptions/exceptions.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.OperationAbortedException = exports.OutstandingTaskAlreadyCompletedException = exports.OperationCanceledException = exports.Exception = void 0;
class Exception extends Error {
    constructor(message, exitCode = 1) {
        super(message.includes("[") ? message : `[Exception] ${message}`);
        this.exitCode = exitCode;
        Object.setPrototypeOf(this, Exception.prototype);
    }
}
exports.Exception = Exception;
class OperationCanceledException extends Exception {
    constructor(message = "Cancelation Requested", exitCode = 1) {
        super(`[OperationCanceledException] ${message}`, exitCode);
        this.exitCode = exitCode;
        Object.setPrototypeOf(this, OperationCanceledException.prototype);
    }
}
exports.OperationCanceledException = OperationCanceledException;
class OutstandingTaskAlreadyCompletedException extends Exception {
    constructor() {
        super("[OutstandingTaskAlreadyCompletedException] The OutstandingTaskAwaiter is already completed, may not Enter() again.", 1);
        Object.setPrototypeOf(this, OutstandingTaskAlreadyCompletedException.prototype);
    }
}
exports.OutstandingTaskAlreadyCompletedException = OutstandingTaskAlreadyCompletedException;
class OperationAbortedException extends Exception {
    constructor() {
        super("[OperationAbortedException] Error occurred. Exiting.", 1);
        Object.setPrototypeOf(this, OperationAbortedException.prototype);
    }
}
exports.OperationAbortedException = OperationAbortedException;
//# sourceMappingURL=exceptions.js.map

/***/ }),

/***/ "../../libs/common/dist/exceptions/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/common/dist/exceptions/exceptions.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/common/dist/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/common/dist/logging/index.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/exceptions/index.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/merging/index.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/utils/index.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/configure.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.configureLibrariesLogger = void 0;
const logger_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure/logger@1.0.2/node_modules/@azure/logger/dist-esm/src/index.js");
/**
 * Configure Autorest Logger.
 * @param level
 */
function configureLibrariesLogger(level, log) {
    (0, logger_1.setLogLevel)(level);
    logger_1.AzureLogger.log = log;
}
exports.configureLibrariesLogger = configureLibrariesLogger;
//# sourceMappingURL=configure.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/console-logger-sink.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ConsoleLogger = exports.ConsoleLoggerSink = void 0;
const cli_progress_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/cli-progress@3.9.1/node_modules/cli-progress/cli-progress.js"));
const formatter_1 = __webpack_require__("../../libs/common/dist/logging/formatter.js");
const logger_1 = __webpack_require__("../../libs/common/dist/logging/logger.js");
/**
 * Logger sink to output logs to the console.
 */
class ConsoleLoggerSink {
    constructor(options = {}) {
        var _a, _b;
        this.options = options;
        this.bars = [];
        this.pendingLogs = [];
        this.stream = (_a = options.stream) !== null && _a !== void 0 ? _a : process.stdout;
        this.format = (_b = options.format) !== null && _b !== void 0 ? _b : "regular";
        this.formatter = (0, formatter_1.createLogFormatter)(options.format, options);
    }
    log(log) {
        const line = this.formatter.log(log);
        if (this.currentProgressBar) {
            this.pendingLogs.push(line);
        }
        else {
            this.writeLine(line);
        }
    }
    startProgress(initialName) {
        if (this.format === "regular") {
            return this.startProgressBar(initialName);
        }
        else {
            return NoopProgress;
        }
    }
    startProgressBar(initialName) {
        if (this.currentProgressBar === undefined) {
            this.currentProgressBar = new cli_progress_1.default.MultiBar({
                hideCursor: true,
                stream: this.stream,
                noTTYOutput: this.options.progressNoTTYOutput,
                format: "{name} [{bar}] {percentage}% | {value}/{total}",
                forceRedraw: true, // without this the bar is flickering,
            }, cli_progress_1.default.Presets.legacy);
        }
        const multiBar = this.currentProgressBar;
        multiBar.on("redraw-pre", () => {
            if (this.pendingLogs.length > 0) {
                if ("clearLine" in this.stream) {
                    this.stream.clearLine(1);
                }
            }
            while (this.pendingLogs.length > 0) {
                this.writeLine(this.pendingLogs.shift());
            }
        });
        multiBar.on("stop", () => {
            this.currentProgressBar = undefined;
            while (this.pendingLogs.length > 0) {
                this.writeLine(this.pendingLogs.shift());
            }
        });
        let bar;
        const update = (progress) => {
            var _a, _b;
            const name = (_b = (_a = progress.name) !== null && _a !== void 0 ? _a : initialName) !== null && _b !== void 0 ? _b : "progress";
            if (bar === undefined) {
                bar = multiBar.create(progress.total, 0, { name });
                this.bars.push(bar);
            }
            else {
                bar.setTotal(progress.total);
            }
            bar.update(progress.current, { name });
        };
        const stop = () => {
            if (bar) {
                bar.update(bar.getTotal());
                bar.render();
                bar.stop();
                multiBar.remove(bar);
                this.bars = this.bars.filter((x) => x !== bar);
                if (this.bars.length === 0) {
                    multiBar.stop();
                    this.currentProgressBar = undefined;
                }
            }
        };
        return {
            update,
            stop,
        };
    }
    writeLine(line) {
        if (line !== undefined) {
            this.stream.write(Buffer.from(`${line}\n`));
        }
    }
}
exports.ConsoleLoggerSink = ConsoleLoggerSink;
/**
 * Simple logger which takes log info as it is and logs it.
 * Doesn't resolve original source locations.
 */
class ConsoleLogger extends logger_1.AutorestSyncLogger {
    constructor(options = {}) {
        super({ sinks: [new ConsoleLoggerSink(options)] });
    }
}
exports.ConsoleLogger = ConsoleLogger;
const NoopProgress = {
    update: () => null,
    stop: () => null,
};
//# sourceMappingURL=console-logger-sink.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/filter-logger-processor.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.shouldLogLevel = exports.FilterLogger = void 0;
const datastore_1 = __webpack_require__("../../libs/datastore/dist/main.js");
const utils_1 = __webpack_require__("../../libs/common/dist/utils/index.js");
/**
 * Logger adding filtering functionality based on:
 *  - level: only show log with level higher than the configuration.
 *  - suppression: List of code that should not be logged.
 */
class FilterLogger {
    constructor(options) {
        var _a;
        this.level = options.level;
        this.suppressions = (_a = options.suppressions) !== null && _a !== void 0 ? _a : [];
    }
    process(log) {
        if (!shouldLogLevel(log, this.level)) {
            return;
        }
        return this.filterSuppressions(log);
    }
    filterSuppressions(log) {
        var _a, _b;
        const hadSource = log.source && log.source.length > 0;
        let currentLog = log;
        // filter
        for (const sup of this.suppressions) {
            // matches key
            const key = (_a = log.code) === null || _a === void 0 ? void 0 : _a.toLowerCase();
            if (key && (key === sup.code || key.startsWith(`${sup.code}/`))) {
                // filter applicable sources
                if (log.source && hadSource) {
                    currentLog = {
                        ...currentLog,
                        source: log.source.filter((s) => !this.matchesSourceFilter(s.document, s.position.path, sup)),
                    };
                }
                else {
                    return undefined;
                }
            }
        }
        // drop message if all source locations have been stripped
        if (hadSource && ((_b = log.source) === null || _b === void 0 ? void 0 : _b.length) === 0) {
            return undefined;
        }
        return log;
    }
    matchesSourceFilter(document, path, supression) {
        // from
        const from = (0, utils_1.arrayify)(supression.from);
        const matchesFrom = from.length === 0 || from.find((d) => document.toLowerCase().endsWith(d.toLowerCase()));
        // where
        const where = (0, utils_1.arrayify)(supression.where);
        const matchesWhere = where.length === 0 || (path && where.find((w) => (0, datastore_1.matches)(w, path))) || false;
        return Boolean(matchesFrom && matchesWhere);
    }
}
exports.FilterLogger = FilterLogger;
const LOG_LEVEL = {
    debug: 10,
    verbose: 20,
    information: 30,
    warning: 40,
    error: 50,
    fatal: 60,
};
function shouldLogLevel(log, level) {
    return LOG_LEVEL[log.level] >= LOG_LEVEL[level];
}
exports.shouldLogLevel = shouldLogLevel;
//# sourceMappingURL=filter-logger-processor.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/formatter.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.JsonLogFormatter = exports.PrettyLogFormatter = exports.createLogFormatter = void 0;
const json_1 = __webpack_require__("../../libs/json/dist/index.js");
const chalk_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/chalk@4.1.2/node_modules/chalk/source/index.js"));
const utils_1 = __webpack_require__("../../libs/common/dist/utils/index.js");
const defaultOptions = {
    color: true,
    timestamp: true,
};
function createLogFormatter(format, options = {}) {
    return format === "json" ? new JsonLogFormatter(options) : new PrettyLogFormatter(options);
}
exports.createLogFormatter = createLogFormatter;
const LEVEL_STR = {
    debug: "debug".padEnd(7),
    verbose: "verbose".padEnd(7),
    information: "info".padEnd(7),
    warning: "warning".padEnd(7),
    error: "error".padEnd(7),
    fatal: "fatal".padEnd(7),
};
const LEVEL_COLORED_STR = {
    debug: chalk_1.default.blue(LEVEL_STR.debug),
    verbose: chalk_1.default.gray(LEVEL_STR.verbose),
    information: chalk_1.default.green(LEVEL_STR.information),
    warning: chalk_1.default.yellow.bold(LEVEL_STR.warning),
    error: chalk_1.default.red.bold(LEVEL_STR.error),
    fatal: chalk_1.default.redBright.bold(LEVEL_STR.fatal),
};
class PrettyLogFormatter {
    constructor(options = {}) {
        this.options = { ...defaultOptions, ...options };
    }
    log(log) {
        var _a;
        const useColor = this.options.color;
        const t = this.formatTimestamp(log.level);
        const level = useColor ? LEVEL_COLORED_STR[log.level] : LEVEL_STR[log.level];
        const message = useColor ? (0, utils_1.color)(log.message) : log.message;
        let text = `${level} |${this.formatCode(log.code)}${t} ${message}`;
        for (const source of (_a = log.source) !== null && _a !== void 0 ? _a : []) {
            text += this.formatSource(source);
        }
        return text;
    }
    formatCode(code) {
        if (!code) {
            return "";
        }
        return ` ${this.color(code, chalk_1.default.green)} |`;
    }
    formatTimestamp(level) {
        if (!(this.options.timestamp && (level === "debug" || level === "verbose"))) {
            return "";
        }
        const colored = this.color(`[${getUpTime()} s]`, chalk_1.default.yellow);
        return ` ${colored}`;
    }
    color(text, color) {
        return this.options.color ? color(text) : text;
    }
    formatSource(source) {
        if (!source.position) {
            return "";
        }
        try {
            return `\n    - ${this.color(source.document, chalk_1.default.cyan)}${this.formatPosition(source.position)}`;
        }
        catch (e) {
            // no friendly name, so nothing more specific to show
            return "";
        }
    }
    formatPosition(position) {
        let text = "";
        if (position.line !== undefined) {
            text += `:${this.color(position.line.toString(), chalk_1.default.cyan.bold)}`;
            if (position.column !== undefined) {
                text += `:${this.color(position.column.toString(), chalk_1.default.cyan.bold)}`;
            }
        }
        const path = position.path ? ` (${(0, json_1.serializeJsonPointer)(position.path)})` : "";
        return `${text}${path}`;
    }
}
exports.PrettyLogFormatter = PrettyLogFormatter;
class JsonLogFormatter {
    constructor(options) {
        this.options = { timestamp: true, ...options };
    }
    log(log) {
        const addTimestamp = this.options.timestamp && (log.level === "debug" || log.level === "verbose");
        const data = addTimestamp ? { ...log, uptime: getUpTime() } : log;
        return JSON.stringify(data);
    }
}
exports.JsonLogFormatter = JsonLogFormatter;
/**
 * @returns uptime of process in seconds
 */
function getUpTime() {
    return process.uptime().toFixed(2);
}
//# sourceMappingURL=formatter.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/common/dist/logging/types.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/logging/logger.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/logging/logger-source-enhancer.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/logging/filter-logger-processor.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/logging/console-logger-sink.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/logging/logging-session.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/logging/formatter.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/logging/configure.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/log-source-enhancer.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.LogSourceEnhancer = void 0;
class LogSourceEnhancer {
    constructor(dataStore) {
        this.dataStore = dataStore;
    }
    async process(log) {
        if (log.source === undefined) {
            return log;
        }
        const sources = await this.resolveOriginalSources(log, log.source);
        return {
            ...log,
            source: this.resolveOriginalDocumentNames(sources),
        };
    }
    async resolveOriginalSources(message, source) {
        const blameSources = source.map(async (s) => {
            let blameTree = null;
            try {
                while (blameTree === null) {
                    try {
                        blameTree = await this.dataStore.blame(s.document, s.position);
                    }
                    catch (e) {
                        if ("path" in s.position) {
                            const path = s.position.path;
                            if (path.length === 0) {
                                throw e;
                            }
                            // adjustment
                            // 1) skip leading `$`
                            if (path[0] === "$") {
                                path.shift();
                            }
                            else {
                                path.pop();
                            }
                        }
                        else {
                            throw e;
                        }
                    }
                }
            }
            catch (e) {
                return [s];
            }
            return blameTree.getMappingLeafs().map((r) => ({
                document: r.source,
                position: { line: r.line, column: r.column },
            }));
        });
        return (await Promise.all(blameSources)).flat();
    }
    resolveOriginalDocumentNames(sources) {
        return sources.map((source) => {
            if (source.position) {
                try {
                    const document = this.dataStore.readStrictSync(source.document).description;
                    return { ...source, document };
                }
                catch (_a) {
                    // no worries
                }
            }
            return source;
        });
    }
}
exports.LogSourceEnhancer = LogSourceEnhancer;
//# sourceMappingURL=log-source-enhancer.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/logger-source-enhancer.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.AutorestLoggerSourceEnhancer = void 0;
const log_source_enhancer_1 = __webpack_require__("../../libs/common/dist/logging/log-source-enhancer.js");
class AutorestLoggerSourceEnhancer {
    constructor(dataStore) {
        this.logInfoEnhancer = new log_source_enhancer_1.LogSourceEnhancer(dataStore);
    }
    async process(log) {
        const enhancedLog = await this.logInfoEnhancer.process(log);
        return enhancedLog;
    }
}
exports.AutorestLoggerSourceEnhancer = AutorestLoggerSourceEnhancer;
//# sourceMappingURL=logger-source-enhancer.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/logger.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.AutorestAsyncLogger = exports.AutorestSyncLogger = exports.AutorestLoggerBase = void 0;
class AutorestLoggerBase {
    constructor(options) {
        var _a;
        this.diagnostics = [];
        this.sinks = options.sinks;
        this.processors = (_a = options.processors) !== null && _a !== void 0 ? _a : [];
    }
    debug(message) {
        this.log({
            level: "debug",
            message,
        });
    }
    verbose(message) {
        this.log({
            level: "verbose",
            message,
        });
    }
    info(message) {
        this.log({
            level: "information",
            message,
        });
    }
    fatal(message) {
        this.log({
            level: "fatal",
            message,
        });
    }
    trackWarning(warning) {
        this.trackDiagnostic({
            level: "warning",
            ...warning,
        });
    }
    trackError(error) {
        this.trackDiagnostic({
            level: "error",
            ...error,
        });
    }
    startProgress(initialName) {
        const sinkProgressTrackers = this.sinks.map((x) => x.startProgress(initialName));
        const update = (progress) => {
            for (const tracker of sinkProgressTrackers) {
                tracker.update(progress);
            }
        };
        const stop = () => {
            for (const tracker of sinkProgressTrackers) {
                tracker.stop();
            }
        };
        return {
            update,
            stop,
        };
    }
    emitLog(log) {
        for (const sink of this.sinks) {
            sink.log(log);
        }
    }
}
exports.AutorestLoggerBase = AutorestLoggerBase;
class AutorestSyncLogger extends AutorestLoggerBase {
    constructor(options) {
        super(options);
        this.diagnostics = [];
    }
    with(...processors) {
        return new AutorestSyncLogger({
            sinks: this.sinks,
            processors: [...processors, ...this.processors],
        });
    }
    trackDiagnostic(diagnostic) {
        const processed = this.process(diagnostic);
        if (processed === undefined) {
            return;
        }
        this.diagnostics.push(processed);
        this.emitLog(processed);
    }
    log(log) {
        const processed = this.process(log);
        if (processed === undefined) {
            return;
        }
        this.emitLog(processed);
    }
    emitLog(log) {
        for (const sink of this.sinks) {
            sink.log(log);
        }
    }
    process(log) {
        let current = log;
        for (const processor of this.processors) {
            const processed = processor.process(log);
            if (processed === undefined) {
                return undefined;
            }
            else {
                current = processed;
            }
        }
        return current;
    }
}
exports.AutorestSyncLogger = AutorestSyncLogger;
class AutorestAsyncLogger extends AutorestLoggerBase {
    constructor(options) {
        super(options);
        this.diagnostics = [];
        this.asyncSession = options.asyncSession;
    }
    with(...processors) {
        return new AutorestAsyncLogger({
            asyncSession: this.asyncSession,
            sinks: this.sinks,
            processors: [...processors, ...this.processors],
        });
    }
    emitLog(log) {
        for (const sink of this.sinks) {
            sink.log(log);
        }
    }
    log(log) {
        this.asyncSession.registerLog(() => this.logMessageAsync(log));
    }
    trackDiagnostic(diagnostic) {
        this.asyncSession.registerLog(() => this.trackDiagnosticAsync(diagnostic));
    }
    async logMessageAsync(log) {
        const processed = await this.process(log);
        if (processed === undefined) {
            return;
        }
        this.emitLog(processed);
    }
    async trackDiagnosticAsync(diagnostic) {
        const processed = await this.process(diagnostic);
        if (processed === undefined) {
            return;
        }
        this.diagnostics.push(processed);
        this.emitLog(processed);
    }
    async process(log) {
        let current = log;
        for (const processor of this.processors) {
            const processed = await processor.process(log);
            if (processed === undefined) {
                return undefined;
            }
            else {
                current = processed;
            }
        }
        return current;
    }
}
exports.AutorestAsyncLogger = AutorestAsyncLogger;
//# sourceMappingURL=logger.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/logging-session.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.AutorestLoggingSession = exports.LoggingSession = void 0;
/**
 * Class processing the logger and disatching async.
 */
class LoggingSession {
    registerLog(sendMessage) {
        var _a;
        this.pendingMessage = ((_a = this.pendingMessage) !== null && _a !== void 0 ? _a : Promise.resolve()).then(async () => {
            try {
                await sendMessage();
            }
            catch (error) {
                // eslint-disable-next-line no-console
                console.error("Unexpected error while logging", error);
            }
        });
    }
    /**
     * Wait for any pending message to be sent.
     */
    async waitForMessages() {
        if (this.pendingMessage) {
            await this.pendingMessage;
        }
    }
}
exports.LoggingSession = LoggingSession;
exports.AutorestLoggingSession = new LoggingSession();
//# sourceMappingURL=logging-session.js.map

/***/ }),

/***/ "../../libs/common/dist/logging/types.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
//# sourceMappingURL=types.js.map

/***/ }),

/***/ "../../libs/common/dist/merging/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/common/dist/merging/merging.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/common/dist/merging/merging.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
/* eslint-disable @typescript-eslint/no-use-before-define */
/* eslint-disable no-prototype-builtins */
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.mergeOverwriteOrAppend = exports.resolveRValue = exports.strictMerge = void 0;
const yaml_1 = __webpack_require__("../../libs/yaml/dist/index.js");
/**
 * Merge a and b by adding new properties of b into a. It will fail if a and b have the same property and the value is different.
 * @param a Object 1 to merge
 * @param b Object 2 to merge
 * @param path current path of the merge.
 */
function strictMerge(a, b, path = []) {
    if (a === null || b === null) {
        throw new Error(`Argument cannot be null ('${(0, yaml_1.Stringify)(path)}')`);
    }
    // trivial case
    if (a === b || JSON.stringify(a) === JSON.stringify(b)) {
        return a;
    }
    // mapping nodes
    if (typeof a === "object" && typeof b === "object") {
        if (a instanceof Array && b instanceof Array) {
            if (a.length === 0) {
                return b;
            }
            if (b.length === 0) {
                return a;
            }
            // both sides gave a sequence, and they are not identical.
            // this is currently not a good thing.
            throw new Error(`'${(0, yaml_1.Stringify)(path)}' has two arrays that are incompatible (${(0, yaml_1.Stringify)(a)}, ${(0, yaml_1.Stringify)(b)}).`);
        }
        else {
            // object nodes - iterate all members
            const result = {};
            const keys = new Set([...Object.keys(a), ...Object.keys(b)]);
            for (const key of keys) {
                const subpath = path.concat(key);
                // forward if only present in one of the nodes
                if (a[key] === undefined) {
                    result[key] = b[key];
                    continue;
                }
                if (b[key] === undefined) {
                    result[key] = a[key];
                    continue;
                }
                // try merge objects otherwise
                const aMember = a[key];
                const bMember = b[key];
                result[key] = strictMerge(aMember, bMember, subpath);
            }
            return result;
        }
    }
    throw new Error(`'${(0, yaml_1.Stringify)(path)}' has incompatible values (${(0, yaml_1.Stringify)(a)}, ${(0, yaml_1.Stringify)(b)}).`);
}
exports.strictMerge = strictMerge;
// Note: I am not convinced this works precisely as it should
// but it works well enough for my needs right now
// I will revisit it later.
const macroRegEx = () => /\$\(([a-zA-Z0-9_-]*)\)/gi;
/**
 * Resolve the expanded value by interpolating any
 * @param value Value to interpolate.
 * @param propertyName Name of the property.
 * @param higherPriority Higher priority context to resolve the interpolation values.
 * @param lowerPriority Lower priority context to resolve the interpolation values.
 * @param jsAware
 */
function resolveRValue(value, propertyName, higherPriority, lowerPriority, jsAware = 0) {
    if (value) {
        // resolves the actual macro value.
        const resolve = (macroExpression, macroKey) => {
            // if the original set has it, use that.
            if (higherPriority && higherPriority[macroKey]) {
                return resolveRValue(higherPriority[macroKey], macroKey, lowerPriority, null, jsAware - 1);
            }
            if (lowerPriority) {
                // check to see if the value is in the overrides set before the key itself.
                const keys = Object.getOwnPropertyNames(lowerPriority);
                const macroKeyLocation = keys.indexOf(macroKey);
                if (macroKeyLocation > -1) {
                    if (macroKeyLocation < keys.indexOf(propertyName)) {
                        // the macroKey is in the overrides, and it precedes the propertyName itself
                        return resolveRValue(lowerPriority[macroKey], macroKey, higherPriority, lowerPriority, jsAware - 1);
                    }
                }
            }
            // can't find the macro. maybe later.
            return macroExpression;
        };
        // resolve the macro value for strings
        if (typeof value === "string") {
            const match = macroRegEx().exec(value.trim());
            if (match) {
                if (match[0] === match.input) {
                    // the target value should be the result without string twiddling
                    if (jsAware > 0) {
                        return JSON.stringify(resolve(match[0], match[1]));
                    }
                    return resolve(match[0], match[1]);
                }
                // it looks like we should do a string replace.
                return value.replace(macroRegEx(), resolve);
            }
        }
        // resolve macro values for array values
        if (value instanceof Array) {
            // since we're not naming the parameter,
            // if there isn't a higher priority,
            // we can fall back to a wide-lookup in lowerPriority.
            return value.map((x) => resolveRValue(x, "", higherPriority || lowerPriority, null));
        }
    }
    if (jsAware > 0) {
        return JSON.stringify(value);
    }
    return value;
}
exports.resolveRValue = resolveRValue;
const defaultOptions = {
    arrayMergeStrategy: "high-pri-first",
    concatListPathFilter: () => false,
};
function mergeOverwriteOrAppend(higherPriority, lowerPriority, options = {}, path = []) {
    var _a;
    if (higherPriority === null || lowerPriority === null) {
        return null;
    }
    const computedOptions = {
        ...defaultOptions,
        ...options,
        interpolationContext: (_a = options.interpolationContext) !== null && _a !== void 0 ? _a : higherPriority,
    };
    // scalars/arrays involved
    if (typeof higherPriority !== "object" ||
        higherPriority instanceof Array ||
        typeof lowerPriority !== "object" ||
        lowerPriority instanceof Array) {
        return mergeArray(higherPriority, lowerPriority, path, computedOptions);
    }
    // object nodes - iterate all members
    const result = {};
    const keys = getKeysInOrder(higherPriority, lowerPriority, computedOptions);
    for (const key of keys) {
        const subpath = path.concat(key);
        // forward if only present in one of the nodes
        if (higherPriority[key] === undefined) {
            result[key] = resolveRValue(lowerPriority[key], key, computedOptions.interpolationContext, lowerPriority);
            continue;
        }
        if (lowerPriority[key] === undefined) {
            result[key] = resolveRValue(higherPriority[key], key, null, computedOptions.interpolationContext);
            continue;
        }
        // try merge objects otherwise
        const aMember = resolveRValue(higherPriority[key], key, lowerPriority, computedOptions.interpolationContext);
        const bMember = resolveRValue(lowerPriority[key], key, computedOptions.interpolationContext, lowerPriority);
        result[key] = mergeOverwriteOrAppend(aMember, bMember, { ...computedOptions, interpolationContext: computedOptions.interpolationContext[key] }, subpath);
    }
    return result;
}
exports.mergeOverwriteOrAppend = mergeOverwriteOrAppend;
/**
 *
 * @param higherPriority Higher priority object
 * @param lowerPriority Lower priority object
 * @param options Merge options.
 * @returns List of unique keys used in both object in the order defined in the options.
 */
function getKeysInOrder(higherPriority, lowerPriority, options) {
    const lowPriKeys = Object.getOwnPropertyNames(lowerPriority);
    const highPriKeys = Object.getOwnPropertyNames(higherPriority);
    return [
        ...new Set(options.arrayMergeStrategy === "low-pri-first" ? lowPriKeys.concat(highPriKeys) : highPriKeys.concat(lowPriKeys)),
    ];
}
function mergeArray(higherPriority, lowerPriority, path, { concatListPathFilter, arrayMergeStrategy }) {
    if (!(higherPriority instanceof Array) && !(lowerPriority instanceof Array) && !concatListPathFilter(path)) {
        return higherPriority;
    }
    const higherPriorityArray = higherPriority instanceof Array ? higherPriority : [higherPriority];
    const lowerPriorityArray = lowerPriority instanceof Array ? lowerPriority : [lowerPriority];
    if (arrayMergeStrategy === "high-pri-first") {
        return [...new Set(higherPriorityArray.concat(lowerPriority))];
    }
    else {
        return [...new Set(lowerPriorityArray.concat(higherPriority))];
    }
}
//# sourceMappingURL=merging.js.map

/***/ }),

/***/ "../../libs/common/dist/utils/coloring.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.color = void 0;
const chalk_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/chalk@4.1.2/node_modules/chalk/source/index.js"));
const NOT_EMPTY_LINE_REGEXP = /^(?!$)/gm;
function color(text) {
    return text
        .replace(/(\[.*?\])/gm, (_, x) => chalk_1.default.yellow.bold(x))
        .replace(/\*\*(.*?)\*\*/gm, (_, x) => chalk_1.default.bold(x))
        .replace(/^# (.*)/gm, (_, x) => chalk_1.default.greenBright(x))
        .replace(/^## (.*)/gm, (_, x) => chalk_1.default.green(x))
        .replace(/^### (.*)/gm, (_, x) => chalk_1.default.cyanBright(x))
        .replace(/(https?:\/\/\S*)/gm, (_, x) => chalk_1.default.blue.bold.underline(x))
        .replace(/_(.*)_/gm, (_, x) => chalk_1.default.italic(x))
        .replace(/^>(.*)/gm, (_, x) => chalk_1.default.cyan(`  ${x}`))
        .replace(/^!(.*)/gm, (_, x) => chalk_1.default.red.bold(`  ${x}`))
        .replace(/```(.*)```/gs, (_, x) => indentAllLines(x, `  ${chalk_1.default.gray("|")} `))
        .replace(/`(.+?)`/gm, (_, x) => chalk_1.default.gray(x))
        .replace(/(".*?")/gm, (_, x) => chalk_1.default.gray(x))
        .replace(/('.*?')/gm, (_, x) => chalk_1.default.gray(x));
}
exports.color = color;
const indentAllLines = (lines, indent) => lines.replace(NOT_EMPTY_LINE_REGEXP, indent);
//# sourceMappingURL=coloring.js.map

/***/ }),

/***/ "../../libs/common/dist/utils/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/common/dist/utils/misc.js"), exports);
__exportStar(__webpack_require__("../../libs/common/dist/utils/coloring.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/common/dist/utils/misc.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.arrayify = exports.isDefined = void 0;
function isDefined(value) {
    return value !== undefined && value !== null;
}
exports.isDefined = isDefined;
function isIterable(target) {
    return !!target && typeof target[Symbol.iterator] === "function";
}
/**
 * Takes a configuration value that can be either an array, a single value or empty and returns an array with all values.
 * @param value Value to wrap in an array.
 * @returns Array of all the values.
 */
function arrayify(value) {
    if (value === undefined) {
        return [];
    }
    switch (typeof value) {
        case "string": // Need to do this case as String is iterable.
            return [value];
        case "object":
            if (isIterable(value)) {
                return [...value];
            }
            break;
    }
    return [value];
}
exports.arrayify = arrayify;
//# sourceMappingURL=misc.js.map

/***/ }),

/***/ "../../libs/configuration/dist/args/autorest-cli-args.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.parseAutorestCliArgs = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const datastore_1 = __webpack_require__("../../libs/datastore/dist/main.js");
const configuration_merging_1 = __webpack_require__("../../libs/configuration/dist/configuration-merging.js");
const configuration_schema_1 = __webpack_require__("../../libs/configuration/dist/configuration-schema/index.js");
const parse_args_1 = __webpack_require__("../../libs/configuration/dist/args/parse-args.js");
function parseAutorestCliArgs(cliArgs) {
    var _a;
    const parsedArgs = (0, parse_args_1.parseArgs)(cliArgs);
    const logger = new common_1.AutorestSyncLogger({
        processors: [
            new common_1.FilterLogger({
                level: parsedArgs.options.debug
                    ? "debug"
                    : parsedArgs.options.verbose
                        ? "verbose"
                        : (_a = parsedArgs.options.level) !== null && _a !== void 0 ? _a : "information",
            }),
        ],
        sinks: [new common_1.ConsoleLoggerSink()],
    });
    if (parsedArgs.positional.length > 1) {
        throw new Error(`Found multiple configuration file arguments: '${parsedArgs.positional.join(",")}'`);
    }
    const configFileOrFolder = parsedArgs.positional[0];
    const optionsAsObjects = parsedArgs.optionList.map(({ key, value }) => (0, datastore_1.CreateObject)(key.split("."), value));
    const config = (0, configuration_merging_1.mergeConfigurations)([configuration_schema_1.AUTOREST_INITIAL_CONFIG, ...optionsAsObjects.reverse()], {
        arrayMergeStrategy: "low-pri-first",
    });
    const result = configuration_schema_1.autorestConfigurationProcessor.processConfiguration(config, {
        logger: logger,
    });
    if ("errors" in result) {
        for (const error of result.errors) {
            logger.trackError({
                code: error.code,
                message: `Invalid Cli Flag: ${error.message}. For flag '${error.path.join(".")}'`,
            });
        }
        throw new common_1.OperationAbortedException();
    }
    return { options: result.value, configFileOrFolder };
}
exports.parseAutorestCliArgs = parseAutorestCliArgs;
//# sourceMappingURL=autorest-cli-args.js.map

/***/ }),

/***/ "../../libs/configuration/dist/args/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/configuration/dist/args/parse-args.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/args/autorest-cli-args.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/configuration/dist/args/parse-args.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.parseArgs = void 0;
const path_1 = __webpack_require__("path");
const yaml_1 = __webpack_require__("../../libs/yaml/dist/index.js");
const untildify_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/untildify@4.0.0/node_modules/untildify/index.js"));
function parseArgs(cliArgs) {
    const result = {
        positional: [],
        options: {},
        optionList: [],
    };
    for (const arg of cliArgs) {
        const match = /^--([^=:]+)([=:](.+))?$/g.exec(arg);
        // configuration file?
        if (match === null) {
            result.positional.push(arg);
            continue;
        }
        // switch
        const key = match[1];
        const rawValue = resolvePathArg(match[3] || "true");
        const value = parseValue(rawValue);
        result.options[key] = value;
        result.optionList.push({ key, value });
    }
    return result;
}
exports.parseArgs = parseArgs;
const cwd = process.cwd();
/**
 * Check if the argument raw value is a relative path or using ~ for user home dir
 * and then convert it to an aboluste one.
 * @param rawValue Raw argument value.
 * @returns string value
 */
function resolvePathArg(rawValue) {
    if (rawValue.startsWith(".")) {
        // starts with a . or .. -> this is a relative path to current directory
        rawValue = (0, path_1.join)(cwd, rawValue);
    }
    return (0, untildify_1.default)(rawValue);
}
/**
 * Parse the flag value.
 * @param rawValue Raw flag value
 * @returns
 */
function parseValue(rawValue) {
    rawValue = rawValue.startsWith("@") ? `'${rawValue}'` : rawValue;
    rawValue = rawValue.match(/20\d\d-\d+-\d+/) ? `'${rawValue}'` : rawValue;
    // quote numbers with decimal point, we don't have any use for non-integer numbers (while on the other hand version strings may look like decimal numbers)
    rawValue = !isNaN(parseFloat(rawValue)) && rawValue.includes(".") ? `'${rawValue}'` : rawValue;
    try {
        return (0, yaml_1.parseYAMLFast)(rawValue);
    }
    catch (e) {
        return rawValue;
    }
}
//# sourceMappingURL=parse-args.js.map

/***/ }),

/***/ "../../libs/configuration/dist/autorest-configuration.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.getBaseFolderUri = exports.resolveAsPath = exports.getNestedConfiguration = exports.extendAutorestConfiguration = exports.createConfigFromRawConfig = exports.createAutorestConfiguration = void 0;
const process_1 = __webpack_require__("process");
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const configuration_merging_1 = __webpack_require__("../../libs/configuration/dist/configuration-merging.js");
const utils_1 = __webpack_require__("../../libs/configuration/dist/utils.js");
const createAutorestConfiguration = async (configFileFolderUri, rawConfig, configurationFiles, fileSystem) => {
    const config = (0, exports.createConfigFromRawConfig)(configFileFolderUri, rawConfig, configurationFiles);
    const inputFiles = await Promise.all((0, utils_1.arrayOf)(rawConfig["input-file"]).map((each) => (0, exports.resolveAsPath)(configFileFolderUri, config, each, fileSystem)));
    const filesToExclude = await Promise.all((0, utils_1.arrayOf)(rawConfig["exclude-file"]).map((each) => (0, exports.resolveAsPath)(configFileFolderUri, config, each, fileSystem)));
    config.inputFileUris = inputFiles.filter((x) => !filesToExclude.includes(x));
    return config;
};
exports.createAutorestConfiguration = createAutorestConfiguration;
const createConfigFromRawConfig = (configFileFolderUri, rawConfig, configurationFiles) => {
    const baseFolderUri = (0, exports.getBaseFolderUri)(configFileFolderUri, rawConfig);
    return {
        ...rawConfig,
        raw: rawConfig,
        configFileFolderUri: configFileFolderUri,
        inputFileUris: [],
        configurationFiles: configurationFiles,
        outputFolderUri: resolveAsWriteableFolder(baseFolderUri, rawConfig["output-folder"]),
        help: Boolean(rawConfig.help),
        verbose: Boolean(rawConfig.verbose),
        cachingEnabled: Boolean(rawConfig.cache),
        cacheExclude: getCacheExclude(rawConfig),
        debug: Boolean(rawConfig.debug),
    };
};
exports.createConfigFromRawConfig = createConfigFromRawConfig;
const getCacheExclude = (config) => {
    const cache = config["cache"];
    return cache && cache.exclude ? (0, utils_1.arrayOf)(cache.exclude) : [];
};
const extendAutorestConfiguration = (config, overrides) => {
    const rawConfig = (0, configuration_merging_1.mergeConfigurations)([...overrides, config.raw]);
    const newConfig = (0, exports.createConfigFromRawConfig)(config.configFileFolderUri, rawConfig, config.configurationFiles);
    newConfig.inputFileUris = config.inputFileUris;
    return newConfig;
};
exports.extendAutorestConfiguration = extendAutorestConfiguration;
function* getNestedConfiguration(config, pluginName) {
    const pp = pluginName.split(".");
    if (pp.length > 1) {
        const n = getNestedConfiguration(config, pp[0]);
        for (const s of n) {
            yield* getNestedConfiguration(s, pp.slice(1).join("."));
        }
        return;
    }
    for (const section of (0, utils_1.arrayOf)(config.raw[pluginName])) {
        if (section) {
            yield (0, exports.extendAutorestConfiguration)(config, section === true ? [] : [section]);
        }
    }
}
exports.getNestedConfiguration = getNestedConfiguration;
const resolveAsPath = (configFileFolderUri, config, path, fileSystem) => {
    var _a;
    // is there even a potential for a parent folder from the input configuruation
    const parentFolder = (_a = config.__parents) === null || _a === void 0 ? void 0 : _a[path];
    const fromBaseUri = (0, uri_1.simplifyUri)((0, uri_1.resolveUri)((0, exports.getBaseFolderUri)(configFileFolderUri, config), path));
    // if it's an absolute uri already, give it back that way.
    if ((0, uri_1.isUri)(path) || !parentFolder) {
        return Promise.resolve(fromBaseUri);
    }
    // let it try relative to the file that loaded it.
    // if the relative-to-parent path isn't valid, we fall back to original behavior
    // where the file path is relative to the base uri.
    // (and we don't even check to see if that's valid, try-require wouldn't need valid files)
    const fromLoadedFile = (0, uri_1.resolveUri)(parentFolder, path);
    return fileSystem.read(fromLoadedFile).then(() => fromLoadedFile, () => fromBaseUri);
};
exports.resolveAsPath = resolveAsPath;
const getBaseFolderUri = (configFileFolderUri, config) => (0, uri_1.ensureIsFolderUri)((0, uri_1.resolveUri)(configFileFolderUri, config["base-folder"]));
exports.getBaseFolderUri = getBaseFolderUri;
const resolveAsFolder = (baseFolderUri, path) => {
    return (0, uri_1.ensureIsFolderUri)((0, uri_1.resolveUri)(baseFolderUri, path));
};
const resolveAsWriteableFolder = (baseFolderUri, path) => {
    // relative paths are relative to the local folder when the base-folder is remote.
    if (!baseFolderUri.startsWith("file:")) {
        return (0, uri_1.ensureIsFolderUri)((0, uri_1.resolveUri)((0, uri_1.createFileOrFolderUri)((0, process_1.cwd)() + "/"), path));
    }
    return resolveAsFolder(baseFolderUri, path);
};
//# sourceMappingURL=autorest-configuration.js.map

/***/ }),

/***/ "../../libs/configuration/dist/autorest-normalized-configuration.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
//# sourceMappingURL=autorest-normalized-configuration.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-file-resolver.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.isConfigurationDocument = exports.detectConfigurationFiles = exports.detectConfigurationFile = void 0;
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const yaml_1 = __webpack_require__("../../libs/yaml/dist/index.js");
const contants_1 = __webpack_require__("../../libs/configuration/dist/contants.js");
/**
 * Get the path to the configuration file.
 * @param fileSystem Filesystem.
 * @param configFileOrFolderUri Uri/folder to check
 * @param logger
 * @param walkUpFolders If it should try to check parent folder recursively.
 */
const detectConfigurationFile = async (fileSystem, configFileOrFolderUri, logger, walkUpFolders = false) => {
    const files = await (0, exports.detectConfigurationFiles)(fileSystem, configFileOrFolderUri, logger, walkUpFolders);
    return (files.filter((x) => x.toLowerCase().endsWith("/" + contants_1.DefaultConfiguration))[0] ||
        files.sort((a, b) => a.length - b.length)[0]);
};
exports.detectConfigurationFile = detectConfigurationFile;
/**
 * Get the paths to all the configuration files.
 * @param fileSystem Filesystem.
 * @param configFileOrFolderUri Uri/folder to check
 * @param logger
 * @param walkUpFolders If it should try to check parent folder recursively.
 */
const detectConfigurationFiles = async (fileSystem, configFileOrFolderUri, logger, walkUpFolders = false) => {
    const originalConfigFileOrFolderUri = configFileOrFolderUri;
    // null means null!
    if (!configFileOrFolderUri) {
        return [];
    }
    // try querying the Uri directly
    let content;
    try {
        content = await fileSystem.ReadFile(configFileOrFolderUri);
    }
    catch (_a) {
        // didn't get the file successfully, move on.
        content = null;
    }
    if (content !== null) {
        if (content.indexOf(contants_1.MagicString) > -1) {
            // the file name was passed in!
            return [configFileOrFolderUri];
        }
        try {
            const ast = (0, yaml_1.parseYAMLAst)(content);
            if (ast) {
                return [configFileOrFolderUri];
            }
        }
        catch (_b) {
            // nope.
        }
        // this *was* an actual file passed in, not a folder. don't make this harder than it has to be.
        throw new Error(`Specified file '${originalConfigFileOrFolderUri}' is not a valid configuration file (missing magic string, see https://github.com/Azure/autorest/blob/main/docs/user/literate-file-formats/configuration.md#the-file-format).`);
    }
    // scan the filesystem items for configurations.
    const results = new Array();
    for (const name of await fileSystem.EnumerateFileUris((0, uri_1.ensureIsFolderUri)(configFileOrFolderUri))) {
        if (name.endsWith(".md")) {
            const content = await fileSystem.ReadFile(name);
            if (content.indexOf(contants_1.MagicString) > -1) {
                results.push(name);
            }
        }
    }
    if (walkUpFolders) {
        // walk up
        const newUriToConfigFileOrWorkingFolder = (0, uri_1.resolveUri)(configFileOrFolderUri, "..");
        if (newUriToConfigFileOrWorkingFolder !== configFileOrFolderUri) {
            results.push(...(await (0, exports.detectConfigurationFiles)(fileSystem, newUriToConfigFileOrWorkingFolder, logger, walkUpFolders)));
        }
    }
    else {
        if (logger && results.length === 0) {
            logger.verbose(`No configuration found at '${originalConfigFileOrFolderUri}'.`);
        }
    }
    return results;
};
exports.detectConfigurationFiles = detectConfigurationFiles;
/**
 * Checks to see if the document is a literate configuation document.
 *
 * @param content the document content to check
 */
async function isConfigurationDocument(content) {
    // this checks to see if the document is an autorest markdown configuration document
    return content.indexOf(contants_1.MagicString) > -1;
}
exports.isConfigurationDocument = isConfigurationDocument;
//# sourceMappingURL=configuration-file-resolver.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-loader/configuration-loader.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ConfigurationLoader = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const datastore_1 = __webpack_require__("../../libs/datastore/dist/main.js");
const extension_1 = __webpack_require__("../../libs/extension/dist/src/index.js");
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const lodash_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/lodash@4.17.21/node_modules/lodash/lodash.js");
const untildify_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/untildify@4.0.0/node_modules/untildify/index.js"));
const configuration_file_resolver_1 = __webpack_require__("../../libs/configuration/dist/configuration-file-resolver.js");
const configuration_manager_1 = __webpack_require__("../../libs/configuration/dist/configuration-manager/index.js");
const configuration_schema_1 = __webpack_require__("../../libs/configuration/dist/configuration-schema/index.js");
const configuration_require_resolver_1 = __webpack_require__("../../libs/configuration/dist/configuration-loader/configuration-require-resolver.js");
/**
 * Timeout in ms.
 */
const InstallPackageTimeout = 5 * 60 * 1000;
/**
 * Class handling the loading of an autorest configuration.
 */
class ConfigurationLoader {
    /**
     * @param fileSystem File system.
     * @param defaultConfigUri Default configuration Uri. This is the path to the default configuration file.
     * @param configFileOrFolderUri Path to the config file or folder.
     */
    constructor(logger, defaultConfigUri, configFileOrFolderUri, options = {}) {
        var _a, _b;
        this.logger = logger;
        this.defaultConfigUri = defaultConfigUri;
        this.configFileOrFolderUri = configFileOrFolderUri;
        const fileSystem = (_a = options.fileSystem) !== null && _a !== void 0 ? _a : new datastore_1.RealFileSystem();
        this.fileSystem = fileSystem instanceof datastore_1.CachingFileSystem ? fileSystem : new datastore_1.CachingFileSystem(fileSystem);
        this.dataStore = (_b = options.dataStore) !== null && _b !== void 0 ? _b : new datastore_1.DataStore({ autoUnloadData: false });
        this.extensionManager = options.extensionManager;
    }
    async load(configs, includeDefault) {
        const configFileUri = this.configFileOrFolderUri
            ? await (0, configuration_file_resolver_1.detectConfigurationFile)(this.fileSystem, this.configFileOrFolderUri, this.logger)
            : undefined;
        const configFileFolderUri = configFileUri
            ? (0, uri_1.resolveUri)(configFileUri, "./")
            : this.configFileOrFolderUri || "file:///";
        const manager = new configuration_manager_1.ConfigurationManager(configFileFolderUri, this.fileSystem);
        const resolveConfig = () => manager.resolveConfig();
        const addedConfigs = new Set();
        const loadConfigFile = async (fileUri, fsToUse) => {
            return this.loadConfigFile(fileUri, fsToUse, manager, addedConfigs);
        };
        const resolveRequiredConfigs = async (fsToUse) => {
            return this.resolveRequiredConfigs(manager, fsToUse, addedConfigs);
        };
        // 1. overrides (CLI, ...)
        // await addSegments(configs, false);
        for (const rawConfig of configs) {
            const result = configuration_schema_1.autorestConfigurationProcessor.processConfiguration(rawConfig, { logger: this.logger });
            if ("errors" in result) {
                for (const error of result.errors) {
                    this.logger.trackError({
                        code: error.code,
                        message: error.message,
                    });
                }
                throw new common_1.OperationAbortedException();
            }
            await manager.addConfig(result.value);
        }
        await resolveRequiredConfigs(this.fileSystem);
        // 2. file
        if (configFileUri != null && configFileUri !== undefined) {
            // add loaded files to the input files.
            this.logger.verbose(`> Initial configuration file '${configFileUri}'`);
            await loadConfigFile(configFileUri, this.fileSystem);
        }
        // 3. default configuration
        const fsLocal = new datastore_1.RealFileSystem();
        if (includeDefault) {
            await loadConfigFile(this.defaultConfigUri, fsLocal);
        }
        // 4. resolve extensions
        const extensions = [];
        if (this.extensionManager) {
            const addedExtensions = new Set();
            const viewsToHandle = [await resolveConfig()];
            while (viewsToHandle.length > 0) {
                const config = viewsToHandle.pop();
                const extensionDefs = resolveExtensions(config);
                const additionalExtensions = extensionDefs.filter((ext) => !addedExtensions.has(ext.fullyQualified));
                await manager.addConfig({ "used-extension": additionalExtensions.map((x) => x.fullyQualified) });
                if (additionalExtensions.length === 0) {
                    continue;
                }
                // acquire additional extensions
                for (const additionalExtension of additionalExtensions) {
                    try {
                        addedExtensions.add(additionalExtension.fullyQualified);
                        const extension = await this.resolveExtension(this.extensionManager, additionalExtension);
                        extensions.push({ extension, definition: additionalExtension });
                        // merge config from extension
                        const extensionConfigurationUri = (0, uri_1.simplifyUri)((0, uri_1.createFileUri)(await extension.configurationPath));
                        this.logger.verbose(`> Including extension configuration file '${extensionConfigurationUri}'`);
                        await loadConfigFile(extensionConfigurationUri, fsLocal);
                        viewsToHandle.push(await resolveConfig());
                    }
                    catch (e) {
                        this.logger.fatal(`Failed to install extension '${additionalExtension.name}' (${additionalExtension.source})`);
                        throw e;
                    }
                }
                await resolveRequiredConfigs(fsLocal);
            }
        }
        // resolve any outstanding includes again
        await resolveRequiredConfigs(fsLocal);
        const config = await manager.resolveConfig();
        // If the pipeline-model was set we set it at the beginning and reload the config.
        // There is some configuration in `default-configuration.md` that depends on pipeline-model but some plugins are setting up pipeline-model.
        if (config["pipeline-model"]) {
            await manager.addHighPriorityConfig({ "pipeline-model": config["pipeline-model"] });
            return { config: await manager.resolveConfig(), extensions };
        }
        else {
            return { config, extensions };
        }
    }
    /**
     * Load the given configuration file and recursively load all required configs.
     * @param fileUri Uri to the configuration file to load.
     * @param fsToUse File system to use to load the configuration files.
     * @param manager Configuration manager
     * @param alreadyAddedConfigs Set of already loaded configuration files.
     */
    async loadConfigFile(fileUri, fsToUse, manager, alreadyAddedConfigs) {
        this.logger.verbose(`> Including configuration file '${fileUri}'`);
        const data = await this.dataStore.getReadThroughScope(fsToUse).readStrict(fileUri);
        const file = await (0, configuration_manager_1.readConfigurationFile)(data, this.logger, this.dataStore.getDataSink());
        manager.addConfigFile(file);
        await this.resolveRequiredConfigs(manager, fsToUse, alreadyAddedConfigs);
    }
    /**
     * Resolve the required configurations that haven't been loaded yet.
     * @param manager Configuration manager.
     * @param fsToUse Filesystem to use to load unloaded configs.
     * @param alreadyAddedConfigs List of configuration already loaded.
     */
    async resolveRequiredConfigs(manager, fsToUse, alreadyAddedConfigs) {
        for await (let additionalConfig of (0, configuration_require_resolver_1.getIncludedConfigurationFiles)(() => manager.resolveConfig(), fsToUse, alreadyAddedConfigs)) {
            // acquire additional configs
            try {
                additionalConfig = (0, uri_1.simplifyUri)(additionalConfig);
                this.logger.verbose(`> Including configuration file '${additionalConfig}'`);
                alreadyAddedConfigs.add(additionalConfig);
                // merge config
                const inputView = this.dataStore.getReadThroughScope(fsToUse);
                const data = await inputView.readStrict(additionalConfig);
                manager.addConfigFile(await (0, configuration_manager_1.readConfigurationFile)(data, this.logger, this.dataStore.getDataSink()));
            }
            catch (e) {
                this.logger.fatal(`Failed to acquire 'require'd configuration '${additionalConfig}'`);
                throw e;
            }
        }
    }
    /**
     * Returns the @see Extension object for the requested extension.
     * @param extensionDef extension definition.
     * @param messageFormat message format.
     */
    async resolveExtension(extMgr, extensionDef) {
        let localPath = (0, untildify_1.default)(extensionDef.source);
        // try resolving the package locally (useful for self-contained)
        try {
            const fileProbe = "/package.json";
            localPath = /*require.resolve*/(__webpack_require__("../../libs/configuration/dist/configuration-loader sync recursive").resolve(extensionDef.name + fileProbe)); // have to resolve specific file - resolving a package by name will fail if no 'main' is present
            localPath = localPath.slice(0, localPath.length - fileProbe.length);
        }
        catch (_a) {
            // no worries
        }
        // trim off the '@org' and 'autorest.' from the name.
        // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
        const shortname = (0, lodash_1.last)(extensionDef.name.split("/")).replace(/^autorest\./gi, "");
        // Add a hint here to make legacy users to be aware that the default version has been bumped to 3.0+.
        if (shortname === "powershell") {
            this.logger.info(`\n## The default version of @autorest/powershell has been bumped from 2.1+ to 3.0+.\n > If you still want to use 2.1+ version, please specify it with --use:@autorest/powershell@2.1.{x}, e.g 2.1.401.\n`);
        }
        if ((await (0, async_io_1.exists)(localPath)) && !localPath.endsWith(".tgz")) {
            localPath = (0, async_io_1.filePath)(localPath);
            // local package
            this.logger.info(`> Loading local AutoRest extension '${extensionDef.name}' (${localPath})`);
            const pack = await extMgr.findPackage(extensionDef.name, localPath);
            return new extension_1.LocalExtension(pack, localPath);
        }
        else {
            // remote package`
            const installedExtension = await extMgr.getInstalledExtension(extensionDef.name, extensionDef.source);
            if (installedExtension) {
                this.logger.info(`> Loading AutoRest extension '${extensionDef.name}' (${extensionDef.source}->${installedExtension.version})`);
                return installedExtension;
            }
            else {
                // acquire extension
                const pack = await extMgr.findPackage(extensionDef.name, extensionDef.source);
                this.logger.info(`> Installing AutoRest extension '${extensionDef.name}' (${extensionDef.source} -> ${pack.version})`);
                const progress = this.logger.startProgress("installing...");
                try {
                    const extension = await extMgr.installPackage(pack, false, InstallPackageTimeout, (status) => {
                        progress.update({ ...status });
                    });
                    progress.stop();
                    this.logger.info(`> Installed AutoRest extension '${extensionDef.name}' (${extensionDef.source}->${extension.version})`);
                    return extension;
                }
                catch (e) {
                    progress.stop();
                    throw e;
                }
            }
        }
    }
}
exports.ConfigurationLoader = ConfigurationLoader;
const resolveExtensions = (config) => {
    const useExtensions = config["use-extension"] || {};
    return Object.keys(useExtensions).map((name) => {
        const source = useExtensions[name].startsWith("file://") ? (0, uri_1.fileUriToPath)(useExtensions[name]) : useExtensions[name];
        return {
            name,
            source,
            fullyQualified: JSON.stringify([name, source]),
        };
    });
};
//# sourceMappingURL=configuration-loader.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-loader/configuration-require-resolver.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.getIncludedConfigurationFiles = void 0;
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const utils_1 = __webpack_require__("../../libs/configuration/dist/utils.js");
/**
 * Resolve required configuration from the provided config.
 * @param resolveConfig Callback to resolve current config.
 * @param fileSystem Filesystem.
 * @param ignoreFiles Current state of files already resolved.
 */
async function* getIncludedConfigurationFiles(resolveConfig, fileSystem, ignoreFiles) {
    let done = false;
    while (!done) {
        // get a fresh copy of the view every time we start the loop.
        const config = await resolveConfig();
        // if we make it thru the list, we're done.
        done = true;
        for (const each of (0, utils_1.arrayOf)(config["require"])) {
            const path = await resolveRequireAsPath(each, config, fileSystem);
            if (ignoreFiles.has(path)) {
                continue;
            }
            // looks like we found one that we haven't handled yet.
            done = false;
            ignoreFiles.add(path);
            yield await resolveRequireAsPath(each, config, fileSystem);
            break;
        }
    }
    done = false;
    while (!done) {
        // get a fresh copy of the view every time we start the loop.
        const config = await resolveConfig();
        // if we make it thru the list, we're done.
        done = true;
        for (const each of (0, utils_1.arrayOf)(config["try-require"])) {
            const path = await resolveRequireAsPath(each, config, fileSystem);
            if (ignoreFiles.has(path)) {
                continue;
            }
            // looks like we found one that we haven't handled yet.
            done = false;
            ignoreFiles.add(path);
            try {
                if (await fileSystem.read(path)) {
                    yield path;
                }
            }
            catch (_a) {
                // do nothing
            }
            break;
        }
    }
}
exports.getIncludedConfigurationFiles = getIncludedConfigurationFiles;
const resolveRequireAsPath = (path, config, fileSystem) => {
    var _a;
    // is there even a potential for a parent folder from the input configuruation
    const parentFolder = (_a = config.__parents) === null || _a === void 0 ? void 0 : _a[path];
    const fromBaseUri = (0, uri_1.resolveUri)(getBaseFolderUri(config), path);
    // if it's an absolute uri already, give it back that way.
    if ((0, uri_1.isUri)(path) || !parentFolder) {
        return Promise.resolve(fromBaseUri);
    }
    // let it try relative to the file that loaded it.
    // if the relative-to-parent path isn't valid, we fall back to original behavior
    // where the file path is relative to the base uri.
    // (and we don't even check to see if that's valid, try-require wouldn't need valid files)
    const fromLoadedFile = (0, uri_1.resolveUri)(parentFolder, path);
    return fileSystem.read(fromLoadedFile).then(() => fromLoadedFile, () => fromBaseUri);
};
const getBaseFolderUri = (config) => {
    return (0, uri_1.ensureIsFolderUri)((0, uri_1.resolveUri)(config.configFileFolderUri, config["base-folder"]));
};
//# sourceMappingURL=configuration-require-resolver.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-loader/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-loader/configuration-loader.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-loader sync recursive":
/***/ ((module) => {

function webpackEmptyContext(req) {
	var e = new Error("Cannot find module '" + req + "'");
	e.code = 'MODULE_NOT_FOUND';
	throw e;
}
webpackEmptyContext.keys = () => ([]);
webpackEmptyContext.resolve = webpackEmptyContext;
webpackEmptyContext.id = "../../libs/configuration/dist/configuration-loader sync recursive";
module.exports = webpackEmptyContext;

/***/ }),

/***/ "../../libs/configuration/dist/configuration-manager/configuration-file.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.readConfigurationFile = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const configuration_schema_1 = __webpack_require__("../../libs/configuration/dist/configuration-schema/index.js");
const desugar_1 = __webpack_require__("../../libs/configuration/dist/desugar.js");
const literate_yaml_1 = __webpack_require__("../../libs/configuration/dist/literate-yaml/index.js");
const utils_1 = __webpack_require__("../../libs/configuration/dist/utils.js");
const readConfigurationFile = async (configFile, logger, sink) => {
    const parentFolder = (0, uri_1.parentFolderUri)(configFile.originalFullPath);
    const base = {
        type: "file",
        fullPath: configFile.originalFullPath,
        configs: [],
    };
    // load config
    const hConfig = await (0, literate_yaml_1.parseConfigFile)(logger, configFile, sink);
    if (hConfig.length === 1 && hConfig[0].info === null && configFile.description.toLowerCase().endsWith(".md")) {
        // this is a whole file, and it's a markdown file.
        return { ...base };
    }
    const configs = await Promise.all(hConfig.filter((x) => x).map((x) => codeBlockToRawConfig(logger, parentFolder, x)));
    return {
        ...base,
        configs,
    };
};
exports.readConfigurationFile = readConfigurationFile;
const codeBlockToRawConfig = async (logger, parentFolder, codeBlock) => {
    var _a;
    const rawConfig = await codeBlock.data.readObject();
    if (!rawConfig) {
        return { config: {} };
    }
    if (typeof rawConfig !== "object") {
        logger.trackError({
            code: "",
            message: "Syntax error: Invalid YAML object.",
            source: [{ document: codeBlock.data.key, position: { line: 1, column: 0 } }],
        });
        throw new common_1.OperationAbortedException();
    }
    const result = configuration_schema_1.autorestConfigurationProcessor.processConfiguration(rawConfig, { logger });
    if ("errors" in result) {
        for (const error of result.errors) {
            logger.trackError({
                code: error.code,
                message: error.message,
                source: [{ document: codeBlock.data.key, position: { path: error.path } }],
            });
        }
        throw new common_1.OperationAbortedException();
    }
    const config = result.value;
    // for ['input-file','try-require', 'require'] paths, we're going to create a node that contains
    // a map of the path to the folder from which the configuration file
    // that loaded it was specified.
    // this will enable us to try to load relative paths relative to the folder from which it was read
    // rather than have to rely on the pseudo $(this-folder) macro (which requires updating the file)
    config.__parents = {};
    const kinds = ["input-file", "require", "try-require", "exclude-file"];
    for (const kind of kinds) {
        if (config[kind]) {
            for (const location of (0, utils_1.arrayOf)(config[kind])) {
                if (!(0, uri_1.isUri)(location)) {
                    config.__parents[location] = parentFolder;
                }
            }
        }
    }
    return {
        condition: (_a = codeBlock.info) !== null && _a !== void 0 ? _a : undefined,
        config: await (0, desugar_1.desugarRawConfig)(config),
    };
};
//# sourceMappingURL=configuration-file.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-manager/configuration-manager.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ConfigurationManager = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const autorest_configuration_1 = __webpack_require__("../../libs/configuration/dist/autorest-configuration.js");
const configuration_schema_1 = __webpack_require__("../../libs/configuration/dist/configuration-schema/index.js");
const desugar_1 = __webpack_require__("../../libs/configuration/dist/desugar.js");
const literate_yaml_1 = __webpack_require__("../../libs/configuration/dist/literate-yaml/index.js");
const defaultConfig = Object.freeze({
    "base-folder": ".",
    "output-folder": "generated",
    debug: false,
    verbose: false,
    "disable-validation": false,
});
/**
 * Class organizing configurations and merging them together.
 * Configuration should be added in order of higher priority to lower priority.
 * This means the first configs values will be able to be used in following configs.
 * This also means that if a property is defined in 2 config the first one will be the one kept.
 */
class ConfigurationManager {
    constructor(configFileOrFolderUri, fileSystem) {
        this.configFileOrFolderUri = configFileOrFolderUri;
        this.fileSystem = fileSystem;
        this.configItems = [];
    }
    async addConfig(config) {
        this.configItems.push({ type: "simple", config: await (0, desugar_1.desugarRawConfig)(config) });
    }
    /**
     * Adds a configuration with high priority.
     * This means this configuration will be loaded first, its value will be able to be used in later configurations.
     * @param config Configuration.
     */
    async addHighPriorityConfig(config) {
        this.configItems.unshift({ type: "simple", config: await (0, desugar_1.desugarRawConfig)(config) });
    }
    /**
     * Adds a configuration.
     * @param config Configuration.
     */
    addConfigFile(file) {
        this.configItems.push(file);
    }
    /**
     * Resolve the @see AutorestConfiguration from all the configurations.
     * It will resolve potential condition for configuration file blocks to be included.
     */
    async resolveConfig() {
        let current = configuration_schema_1.AUTOREST_INITIAL_CONFIG;
        const configFileNames = [];
        for (const configItem of this.configItems) {
            if (configItem.type === "file") {
                current = this.mergeConfigFile(current, configItem);
                configFileNames.push(configItem.fullPath);
            }
            else if (configItem.type === "simple") {
                current = (0, common_1.mergeOverwriteOrAppend)(current, configItem.config);
            }
        }
        // Finally apply default config.
        const finalConfig = (0, common_1.mergeOverwriteOrAppend)(current, defaultConfig);
        return (0, autorest_configuration_1.createAutorestConfiguration)(this.configFileOrFolderUri, finalConfig, configFileNames, this.fileSystem);
    }
    /**
     * Merge the given config file into the given config. Config file doesn't override values.
     * @param config Current config. Will be used to resolve values in the config file.(Such as condition or interpolate values).
     * @param configFile Config file.
     */
    mergeConfigFile(config, configFile) {
        var _a, _b;
        let currentFileResolution = { ...configuration_schema_1.AUTOREST_INITIAL_CONFIG };
        const resolveConfig = () => (0, common_1.mergeOverwriteOrAppend)(config, currentFileResolution);
        for (const configBlock of configFile.configs) {
            const resolvedConfig = resolveConfig();
            // if they say --profile: or --api-version: (or in config) then we force it to set the tag=all-api-versions
            // Some of the rest specs had a default tag set (really shouldn't have done that), which ... was problematic,
            // so this enables us to override that in the case they are asking for filtering to a profile or a api-verison
            const forceAllVersionsMode = Boolean(((_a = resolvedConfig["api-version"]) === null || _a === void 0 ? void 0 : _a.length) || ((_b = resolvedConfig.profile) === null || _b === void 0 ? void 0 : _b.length));
            const shouldInclude = shouldIncludeConditionalConfig(resolvedConfig, configBlock, forceAllVersionsMode);
            if (shouldInclude) {
                currentFileResolution = (0, common_1.mergeOverwriteOrAppend)(configBlock.config, currentFileResolution, {
                    arrayMergeStrategy: "low-pri-first",
                    interpolationContext: (0, common_1.mergeOverwriteOrAppend)(config, configBlock.config),
                });
            }
        }
        return resolveConfig();
    }
}
exports.ConfigurationManager = ConfigurationManager;
const shouldIncludeConditionalConfig = (context, config, forceAllVersionsMode) => (config.condition ? (0, literate_yaml_1.evaluateGuard)(config.condition, context, forceAllVersionsMode) : true);
//# sourceMappingURL=configuration-manager.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-manager/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-manager/configuration-manager.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-manager/configuration-file.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-merging.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.mergeConfigurations = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
function mergeConfigurations(configs, options = {}) {
    return configs.reduce((result, config) => (0, common_1.mergeOverwriteOrAppend)(result, config), options);
}
exports.mergeConfigurations = mergeConfigurations;
//# sourceMappingURL=configuration-merging.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-schema/autorest-configuration-schema.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.AUTOREST_INITIAL_CONFIG = exports.autorestConfigurationProcessor = exports.AUTOREST_CONFIGURATION_DEFINITION_FOR_HELP = exports.AUTOREST_CONFIGURATION_DEFINITION = exports.AUTOREST_CONFIGURATION_SCHEMA = exports.SUPPORTED_EXTENSIONS_SCHEMA = exports.AUTOREST_CONFIGURATION_CATEGORIES = void 0;
const processor_1 = __webpack_require__("../../libs/configuration/dist/configuration-schema/processor.js");
exports.AUTOREST_CONFIGURATION_CATEGORIES = {
    logging: {
        name: "Logging",
    },
    installation: {
        name: "Manage installation",
    },
    core: {
        name: "Core Settings",
    },
    feature: {
        name: "Feature flags",
    },
    extensions: {
        name: "Generators and extensions",
        description: "> While AutoRest can be extended arbitrarily by 3rd parties (say, with a custom generator),\n> we officially support and maintain the following functionality.\n> More specific help is shown when combining the following switches with `--help` .",
    },
};
exports.SUPPORTED_EXTENSIONS_SCHEMA = {
    csharp: {
        type: "boolean",
        category: "extensions",
        description: "Generate C# client code",
    },
    go: {
        type: "boolean",
        category: "extensions",
        description: "Generate Go client code",
    },
    java: {
        type: "boolean",
        category: "extensions",
        description: "Generate Java client code",
    },
    python: {
        type: "boolean",
        category: "extensions",
        description: "Generate Python client code",
    },
    az: {
        type: "boolean",
        category: "extensions",
        description: "Generate Az cli code",
    },
    typescript: {
        type: "boolean",
        category: "extensions",
        description: "Generate TypeScript client code",
    },
    azureresourceschema: {
        type: "boolean",
        category: "extensions",
        description: "Generate Azurer resource schemas",
    },
    "model-validator": {
        type: "boolean",
        category: "extensions",
        description: "Validates an OpenAPI document against linked examples (see https://github.com/Azure/azure-rest-api-specs/search?q=x-ms-examples ",
    },
    "azure-validator": {
        type: "boolean",
        category: "extensions",
        description: "Validates an OpenAPI document against guidelines to improve quality (and optionally Azure guidelines)",
    },
};
// Switch next 2 lines to have autocomplete when writting configuration. Make sure to revert otherwise it lose the detailed typing for each option.
// export const AUTOREST_CONFIGURATION_SCHEMA : RootConfigurationSchema<keyof typeof AUTOREST_CONFIGURATION_CATEGORIES> = {
exports.AUTOREST_CONFIGURATION_SCHEMA = {
    /**
     * Verbosity category
     */
    verbose: { type: "boolean", category: "logging", description: "Display verbose logging information" },
    debug: { type: "boolean", category: "logging", description: "Display debug logging information" },
    level: {
        type: "string",
        category: "logging",
        enum: ["debug", "verbose", "information", "warning", "error", "fatal"],
        description: "Set logging level",
    },
    "message-format": {
        type: "string",
        category: "logging",
        description: "Format of logging messages",
        enum: ["json", "regular"],
    },
    /**
     * Manage installation category
     */
    info: {
        type: "boolean",
        category: "installation",
        description: "Display information about the installed version of autorest and its extensions",
    },
    "list-available": {
        type: "boolean",
        category: "installation",
        description: "Display available AutoRest versions",
    },
    reset: {
        type: "boolean",
        category: "installation",
        description: "Removes all autorest extensions and downloads the latest version of the autorest-core extension",
    },
    preview: {
        type: "boolean",
        category: "installation",
        description: "Enables using autorest extensions that are not yet released",
    },
    latest: {
        type: "boolean",
        category: "installation",
        description: "Install the latest autorest-core extension",
    },
    force: {
        type: "boolean",
        category: "installation",
        description: "Force the re-installation of the autorest-core extension and frameworks",
    },
    version: {
        type: "string",
        category: "installation",
        description: "Use the specified version of the autorest-core extension",
    },
    use: {
        type: "array",
        category: "installation",
        items: { type: "string" },
        description: "Specify an extension to load and use. Format: --use=<packagename>[@<version>] (e.g. --use=@autorest/modelerfour@~4.19.0)",
    },
    "use-extension": {
        type: "dictionary",
        category: "installation",
        description: `Specify extension to load and use. Format: {"<packageName>": "<version>"}`,
        items: { type: "string" },
    },
    /**
     * Core settings
     */
    help: {
        type: "boolean",
        category: "core",
        description: "Display help (combine with flags like --csharp to get further details about specific functionality)",
    },
    memory: { type: "string", category: "core", description: "Configure max memory allowed for autorest process(s)" },
    "input-file": {
        type: "array",
        category: "core",
        description: "OpenAPI file to use as input (use this setting repeatedly to pass multiple files at once)",
        items: { type: "string" },
    },
    "output-folder": {
        type: "string",
        category: "core",
        description: `Target folder for generated artifacts; default: "<base folder>/generated"`,
    },
    "github-auth-token": {
        type: "string",
        category: "core",
        description: "OAuth token to use when pointing AutoRest at files living in a private GitHub repository",
    },
    "azure-arm": {
        type: "boolean",
        category: "core",
        description: "Generate code in Azure flavor",
    },
    "header-text": {
        type: "string",
        category: "core",
        description: "Text to include as a header comment in generated files (magic strings:MICROSOFTMIT, MICROSOFT_APACHE, MICROSOFT_MIT_NO_VERSION, MICROSOFT_APACHE_NO_VERSION, MICROSOFT_MIT_NOCODEGEN)",
    },
    "openapi-type": {
        type: "string",
        category: "core",
        description: `Open API Type: "arm" or "data-plane"`,
    },
    "output-converted-oai3": {
        type: "boolean",
        category: "core",
        description: `If enabled and the input-files are swager 2.0 this will output the resulting OpenAPI3.0 converted files to the output-folder`,
    },
    eol: {
        type: "string",
        category: "core",
        enum: ["default", "lf", "crlf"],
        description: "Change the end of line character for generated output.",
    },
    title: {
        type: "string",
        category: "core",
        description: "Override the service client's name listed in the swagger under title.",
    },
    "override-client-name": {
        type: "string",
        category: "core",
        description: "Name to use for the generated client type. By default, uses the value of the 'Title' field from the input files",
    },
    directive: {
        type: "array",
        category: "core",
        items: {
            type: "object",
            properties: {
                from: { type: "array", items: { type: "string" } },
                // directive is also used in the powershell extension (where and set in particular are object there) https://github.com/Azure/autorest.powershell/blob/main/docs/directives.md
                // where: { type: "array", items: { type: "string" } },
                reason: { type: "string" },
                suppress: { type: "array", deprecated: true, items: { type: "string" } },
                // set: { type: "array", items: { type: "string" } },
                transform: { type: "array", items: { type: "string" } },
                "text-transform": { type: "array", items: { type: "string" } },
                test: { type: "array", items: { type: "string" } },
                debug: {
                    type: "boolean",
                    description: "Debug this directive. When set to true autorest will log additional information regarding that directive.",
                },
            },
        },
    },
    require: {
        type: "array",
        category: "core",
        description: "Additional configuration file(s) to include.",
        items: { type: "string" },
    },
    "try-require": {
        type: "array",
        category: "core",
        description: "Additional configuration file(s) to try to include. Will not fail if the configuration file doesn't exist.",
        items: { type: "string", description: "Additional configuration files to include." },
    },
    "declare-directive": {
        type: "dictionary",
        category: "core",
        description: "Declare some reusable directives (https://github.com/Azure/autorest/blob/main/packages/libs/configuration/resources/directives.md#how-it-works)",
        items: { type: "string" },
    },
    "output-artifact": {
        type: "array",
        category: "core",
        description: "Additional artifact type to emit to the output-folder",
        items: { type: "string" },
    },
    "allow-no-input": { type: "boolean" },
    "exclude-file": { type: "array", items: { type: "string" } },
    "base-folder": { type: "string" },
    stats: { type: "boolean", category: "core", description: "Output some statistics about current autorest run." },
    profile: {
        type: "array",
        category: "core",
        description: "Reservered for future use.",
        items: { type: "string" },
    },
    suppressions: {
        type: "array",
        category: "core",
        description: "List of warning/error code to ignore.",
        items: {
            type: "object",
            properties: {
                code: { type: "string" },
                from: { type: "array", items: { type: "string" } },
                where: { type: "array", items: { type: "string" } },
                reason: { type: "string" },
            },
        },
    },
    "output-file": { type: "string" },
    /**
     * Feature flags
     */
    "deduplicate-inline-models": { type: "boolean", category: "feature", description: "Deduplicate inline models" },
    "include-x-ms-examples-original-file": {
        type: "boolean",
        category: "feature",
        description: "Include x-ms-original-file property in x-ms-examples",
    },
    /**
     * Ignore.
     */
    "pass-thru": {
        type: "array",
        items: { type: "string" },
    },
};
exports.AUTOREST_CONFIGURATION_DEFINITION = {
    categories: exports.AUTOREST_CONFIGURATION_CATEGORIES,
    schema: exports.AUTOREST_CONFIGURATION_SCHEMA,
};
exports.AUTOREST_CONFIGURATION_DEFINITION_FOR_HELP = {
    categories: exports.AUTOREST_CONFIGURATION_CATEGORIES,
    // SUPPORTED_EXTENSIONS_SCHEMA can either be a flag to enable or a scope which cause issue with the validation.
    schema: { ...exports.AUTOREST_CONFIGURATION_SCHEMA, ...exports.SUPPORTED_EXTENSIONS_SCHEMA },
};
exports.autorestConfigurationProcessor = new processor_1.ConfigurationSchemaProcessor(exports.AUTOREST_CONFIGURATION_DEFINITION);
exports.AUTOREST_INITIAL_CONFIG = exports.autorestConfigurationProcessor.getInitialConfig();
//# sourceMappingURL=autorest-configuration-schema.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-schema/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-schema/autorest-configuration-schema.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-schema/types.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-schema/processor.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-schema/processor.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ConfigurationSchemaProcessor = exports.ProcessingErrorCode = void 0;
const util_1 = __webpack_require__("util");
const lodash_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/lodash@4.17.21/node_modules/lodash/lodash.js");
var ProcessingErrorCode;
(function (ProcessingErrorCode) {
    ProcessingErrorCode["UnknownProperty"] = "unknownProperty";
    ProcessingErrorCode["InvalidType"] = "invalidType";
})(ProcessingErrorCode = exports.ProcessingErrorCode || (exports.ProcessingErrorCode = {}));
class ConfigurationSchemaProcessor {
    constructor(def) {
        this.def = def;
    }
    processConfiguration(configuration, options) {
        return processConfiguration(this.def.schema, [], configuration, options);
    }
    /**
     * Returns an empty config with all array property to be able to work with @see mergeConfigurations.
     */
    getInitialConfig() {
        return getInitialConfig(this.def.schema);
    }
}
exports.ConfigurationSchemaProcessor = ConfigurationSchemaProcessor;
function getInitialConfig(schema) {
    const config = {};
    for (const [key, value] of Object.entries(schema)) {
        if (value.type === "array") {
            config[key] = [];
        }
        else if (value.type === "object") {
            const nested = getInitialConfig(value.properties);
            if (Object.keys(nested).length > 0) {
                config[key] = nested;
            }
        }
    }
    return Object.freeze(config);
}
function processConfiguration(schema, path, configuration, options) {
    const errors = [];
    const result = {};
    for (const [key, value] of Object.entries(configuration)) {
        const propertySchema = schema[key];
        const propertyPath = [...path, key];
        if (!propertySchema) {
            // Don't fail for now as any property could be used. See if we can make use of this latter(Maybe using a flag)
            // errors.push({
            //   code: ProcessingErrorCode.UnknownProperty,
            //   message: `Property ${key} is not defined in the schema.`,
            //   path: propertyPath,
            // });
            result[key] = value;
            continue;
        }
        const propertyResult = processProperty(propertySchema, propertyPath, value, options);
        if (isErrorResult(propertyResult)) {
            errors.push(...propertyResult.errors);
        }
        else {
            result[key] = propertyResult.value;
            if (propertySchema.deprecated) {
                options.logger.trackWarning({
                    code: "DeprecatedConfig",
                    message: `Using ${propertyPath.join(".")} which is deprecated and will be removed in the future.`,
                });
            }
        }
    }
    return errors.length > 0 ? { errors } : { value: result };
}
function processProperty(schema, path, value, options) {
    if (schema.type === "array") {
        if (value === undefined) {
            return { value: [] };
        }
        if (Array.isArray(value)) {
            const result = value.map((x, i) => processPrimitiveProperty(schema.items, [...path, i.toString()], x, options));
            const values = result.filter(isNotErrorResult).map((x) => x.value);
            const errors = (0, lodash_1.flatMap)(result.filter(isErrorResult).map((x) => x.errors));
            if (errors.length > 0) {
                return { errors };
            }
            return { value: values };
        }
        else {
            const result = processPrimitiveProperty(schema.items, path, value, options);
            if (isErrorResult(result)) {
                return result;
            }
            else {
                return { value: [result.value] };
            }
        }
    }
    else if (schema.type === "dictionary") {
        if (value === undefined) {
            return { value: {} };
        }
        if (typeof value !== "object") {
            return { errors: [createInvalidTypeError(value, "object", path)] };
        }
        const result = {};
        for (const [key, dictValue] of Object.entries(value !== null && value !== void 0 ? value : {})) {
            const prop = processProperty(schema.items, [...path, key], dictValue, options);
            if ("errors" in prop) {
                return { errors: prop.errors };
            }
            result[key] = prop.value;
        }
        return { value: result };
    }
    else {
        if (value === undefined) {
            return { value: undefined };
        }
        return processPrimitiveProperty(schema, path, value, options);
    }
}
function processPrimitiveProperty(schema, path, value, options) {
    switch (schema.type) {
        case "object":
            return processConfiguration(schema.properties, path, value, options);
        case "number": {
            if (typeof value !== "number") {
                return {
                    errors: [createInvalidTypeError(value, "number", path)],
                };
            }
            return { value };
        }
        case "boolean":
            if (typeof value !== "boolean") {
                return {
                    errors: [createInvalidTypeError(value, "boolean", path)],
                };
            }
            return { value };
        case "string": {
            if (typeof value !== "string") {
                return {
                    errors: [createInvalidTypeError(value, "string", path)],
                };
            }
            if (schema.enum) {
                if (!schema.enum.includes(value)) {
                    const serializedValue = (0, util_1.inspect)(value);
                    return {
                        errors: [
                            {
                                code: ProcessingErrorCode.InvalidType,
                                message: `Expected a value to be in [${schema.enum
                                    .map((x) => `'${x}'`)
                                    .join(",")}] but got ${serializedValue}`,
                                path,
                            },
                        ],
                    };
                }
            }
            return { value };
        }
    }
}
function createInvalidTypeError(value, expectedType, path) {
    const serializedValue = (0, util_1.inspect)(value);
    return {
        code: ProcessingErrorCode.InvalidType,
        message: `Expected a ${expectedType} but got ${typeof value}: ${serializedValue}`,
        path,
    };
}
function isErrorResult(value) {
    return "errors" in value;
}
function isNotErrorResult(value) {
    return !("errors" in value);
}
//# sourceMappingURL=processor.js.map

/***/ }),

/***/ "../../libs/configuration/dist/configuration-schema/types.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
//# sourceMappingURL=types.js.map

/***/ }),

/***/ "../../libs/configuration/dist/contants.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.MagicString = exports.DefaultConfiguration = void 0;
exports.DefaultConfiguration = "readme.md";
/**
 * Magic string that should be inside a markdown configuration to mark it as an autorest config.
 */
exports.MagicString = "\n> see https://aka.ms/autorest";
//# sourceMappingURL=contants.js.map

/***/ }),

/***/ "../../libs/configuration/dist/desugar.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.desugarRawConfig = void 0;
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const extension_1 = __webpack_require__("../../libs/extension/dist/src/index.js");
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const lodash_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/lodash@4.17.21/node_modules/lodash/lodash.js");
const desugarUseField = async (use) => {
    // Create an empty extension manager to be able to call findPackages.
    const useArray = typeof use === "string" ? [use] : use;
    const extensions = {};
    for (const useEntry of useArray) {
        if (typeof useEntry === "string") {
            // potential formats:
            // <pkg>
            // <pkg>@<version>
            // @<org>/<pkg>
            // @<org>/<pkg>@<version>
            // <path>
            // <path/uri to .tgz package file>
            // if the entry starts with an @ it's definitely a package reference
            if (useEntry.endsWith(".tgz") || (await (0, async_io_1.isDirectory)(useEntry)) || useEntry.startsWith("file:/")) {
                const pkg = await (0, extension_1.fetchPackageMetadata)(useEntry);
                extensions[pkg.name] = useEntry;
            }
            else {
                const [, identity, version] = /^https?:\/\//g.exec(useEntry)
                    ? [undefined, useEntry, undefined]
                    : /(^@.*?\/[^@]*|[^@]*)@?(.*)/.exec(useEntry);
                if (identity) {
                    // parsed correctly
                    if (version) {
                        extensions[identity] = version;
                    }
                    else {
                        // it's either a location or just the name
                        if ((0, uri_1.isUri)(identity) || (await (0, async_io_1.exists)(identity))) {
                            // seems like it's a location to something. we don't know the actual name at this point.
                            const pkg = await (0, extension_1.fetchPackageMetadata)(identity);
                            extensions[pkg.name] = identity;
                        }
                        else {
                            extensions[identity] = "*";
                        }
                    }
                }
            }
        }
    }
    return extensions;
};
/**
 * Resolve some sugar properties.
 * @param rawConfig Config to clean.
 */
const desugarRawConfig = async (rawConfig) => {
    var _a;
    return {
        ...(0, lodash_1.omit)(rawConfig, "licence-header"),
        "license-header": (_a = rawConfig["license-header"]) !== null && _a !== void 0 ? _a : rawConfig["licence-header"],
        "use-extension": {
            ...rawConfig["use-extension"],
            ...(rawConfig.use && (await desugarUseField(rawConfig.use))),
        },
    };
};
exports.desugarRawConfig = desugarRawConfig;
//# sourceMappingURL=desugar.js.map

/***/ }),

/***/ "../../libs/configuration/dist/directive.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.resolveDirectives = exports.ResolvedDirective = void 0;
const datastore_1 = __webpack_require__("../../libs/datastore/dist/main.js");
const lodash_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/lodash@4.17.21/node_modules/lodash/lodash.js");
const utils_1 = __webpack_require__("../../libs/configuration/dist/utils.js");
const safeEval = (0, datastore_1.createSandbox)();
class ResolvedDirective {
    constructor(directive) {
        var _a;
        // copy untyped content over
        Object.assign(this, directive);
        // normalize typed content
        this.from = (0, utils_1.arrayOf)(directive["from"]);
        this.where = (0, utils_1.arrayOf)(directive["where"]);
        this.reason = directive.reason;
        this.suppress = (0, utils_1.arrayOf)(directive["suppress"]);
        this.transform = (0, utils_1.arrayOf)(directive["transform"] || directive["text-transform"]);
        this.test = (0, utils_1.arrayOf)(directive["test"]);
        this.debug = (_a = directive.debug) !== null && _a !== void 0 ? _a : false;
    }
    get name() {
        return `${this.from} @ ${this.where}`;
    }
}
exports.ResolvedDirective = ResolvedDirective;
/**
 * Returns list of ResolvedDirective matching the given predicate.
 * @param config Configuration containing directives.
 * @param predicate Optional filter condition.
 */
const resolveDirectives = (config, predicate) => {
    // optionally filter by predicate.
    const plainDirectives = (0, utils_1.arrayOf)(config["directive"]);
    const declarations = config["declare-directive"] || {};
    const expandDirective = (dir) => {
        const makro = Object.keys(dir).filter((m) => declarations[m])[0];
        if (!makro) {
            return [dir]; // nothing to expand
        }
        // prepare directive
        let parameters = dir[makro];
        if (!Array.isArray(parameters)) {
            parameters = [parameters];
        }
        dir = { ...dir };
        delete dir[makro];
        // call makro
        const makroResults = (0, lodash_1.flatMap)(parameters, (parameter) => {
            const result = safeEval(declarations[makro], { $: parameter, $context: dir });
            return Array.isArray(result) ? result : [result];
        });
        return (0, lodash_1.flatMap)(makroResults, (result) => expandDirective({ ...result, ...dir }));
    };
    // makro expansion
    if (predicate) {
        return (0, lodash_1.flatMap)(plainDirectives, expandDirective)
            .map((each) => new ResolvedDirective(each))
            .filter(predicate);
    }
    return (0, lodash_1.flatMap)(plainDirectives, expandDirective).map((each) => new ResolvedDirective(each));
    // return From(plainDirectives).SelectMany(expandDirective).Select(each => new StaticDirectiveView(each)).ToArray();
};
exports.resolveDirectives = resolveDirectives;
//# sourceMappingURL=directive.js.map

/***/ }),

/***/ "../../libs/configuration/dist/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/configuration/dist/args/index.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/autorest-configuration.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/autorest-normalized-configuration.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-schema/index.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-manager/index.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-file-resolver.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-loader/index.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/configuration-merging.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/directive.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/utils.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/configuration/dist/literate-yaml/error-codes.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.LiterateYamlErrorCodes = void 0;
/**
 * Mapping of literate yaml error codes.
 */
exports.LiterateYamlErrorCodes = {
    jsonParsingError: "literate/json-parsing-error",
    yamlParsingError: "literate/yaml-parsing-error",
};
//# sourceMappingURL=error-codes.js.map

/***/ }),

/***/ "../../libs/configuration/dist/literate-yaml/guard.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.evaluateGuard = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const datastore_1 = __webpack_require__("../../libs/datastore/dist/main.js");
const safeEval = (0, datastore_1.createSandbox)();
function evaluateGuard(rawFenceGuard, contextObject, forceAllVersionsMode = false) {
    // extend the context object so that we can have some helper functions.
    contextObject = {
        ...contextObject,
        /** finds out if there is an extension being loaded already by a given name */
        isLoaded: (name) => {
            return (contextObject["used-extension"] &&
                !!contextObject["used-extension"].find((each) => each.startsWith(`["${name}"`)));
        },
        /** allows a check to see if a given extension is being requested already */
        isRequested: (name) => {
            var _a;
            return (_a = contextObject["use-extension"]) === null || _a === void 0 ? void 0 : _a[name];
        },
        /** if they are specifying one or more profiles or api-versions, then they are   */
        enableAllVersionsMode: () => {
            return forceAllVersionsMode;
        },
        /** prints a debug message from configuration. sssshhh. don't use this.  */
        debugMessage: (text) => {
            // eslint-disable-next-line no-console
            console.log(text);
            return true;
        },
    };
    // trim the language from the front first
    let match = /^\S*\s*(.*)/.exec(rawFenceGuard);
    const fence = match && match[1];
    if (!fence) {
        // no fence at all.
        return true;
    }
    let guardResult = false;
    let expressionFence = "";
    try {
        if (!fence.includes("$(")) {
            try {
                return safeEval(fence, contextObject);
            }
            catch (e) {
                //console.log(`1 failed to eval ${fence}`);
                return false;
            }
        }
        expressionFence = `${(0, common_1.resolveRValue)(fence, "", contextObject, null, 2)}`;
        // is there unresolved values?  May be old-style. Or the values aren't defined.
        // Let's run it only if there are no unresolved values for now.
        if (!expressionFence.includes("$(")) {
            return safeEval(expressionFence, contextObject);
        }
    }
    catch (E) {
        // console.log(`2 failed to eval ${expressionFence}`);
        // not a legal expression?
    }
    // is this a single $( ... ) expression ?
    match = /^\$\((.*)\)$/.exec(fence.trim());
    const guardExpression = match && !match[1].includes("$(") && match[1];
    if (!guardExpression) {
        // Nope. this isn't an old style expression.
        // at best, it can be an expression that doesn't have all the values resolved.
        // let's resolve them to undefined and see what happens.
        try {
            return safeEval(expressionFence.replace(/\$\(.*?\)/g, "undefined"), contextObject);
        }
        catch (_a) {
            // console.log(`3 failed to eval ${expressionFence.replace(/\$\(.*?\)/g, 'undefined')}`);
            try {
                return safeEval(fence.replace(/\$\(.*?\)/g, "undefined"), contextObject);
            }
            catch (_b) {
                //console.log(`4 failed to eval ${fence.replace(/\$\(.*?\)/g, 'undefined')}`);
                return false;
            }
        }
    }
    // fall back to original behavior, where the whole expression is in the $( ... )
    const context = { $: contextObject, ...contextObject };
    try {
        guardResult = safeEval(guardExpression, context);
    }
    catch (e) {
        try {
            guardResult = safeEval("$['" + guardExpression + "']", context);
        }
        catch (e) {
            // at this point, it can only be an single-value expression that isn't resolved
            // which means return 'false'
        }
    }
    return guardResult;
}
exports.evaluateGuard = evaluateGuard;
//# sourceMappingURL=guard.js.map

/***/ }),

/***/ "../../libs/configuration/dist/literate-yaml/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/configuration/dist/literate-yaml/literate-yaml.js"), exports);
__exportStar(__webpack_require__("../../libs/configuration/dist/literate-yaml/guard.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/configuration/dist/literate-yaml/literate-yaml.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.parseConfigFile = void 0;
const common_1 = __webpack_require__("../../libs/common/dist/index.js");
const datastore_1 = __webpack_require__("../../libs/datastore/dist/main.js");
const json_1 = __webpack_require__("../../libs/json/dist/index.js");
const yaml_1 = __webpack_require__("../../libs/yaml/dist/index.js");
const error_codes_1 = __webpack_require__("../../libs/configuration/dist/literate-yaml/error-codes.js");
const markdown_parser_1 = __webpack_require__("../../libs/configuration/dist/literate-yaml/markdown-parser.js");
function tryMarkdown(rawMarkdownOrYaml) {
    return /^#/gm.test(rawMarkdownOrYaml);
}
/**
 * Parse an autorest config file either in markdown format(with multiple code blocks and guard) or as a yaml/json file.
 * @param logger Logger.
 * @param file File to parse.
 * @param sink Data sink
 * @returns List of parsed config blocks if markdown or a single one if a yaml/json file.
 */
async function parseConfigFile(logger, file, sink) {
    let hsConfigFileBlocks = [];
    const rawMarkdown = await file.readData();
    // try parsing as literate YAML
    if (tryMarkdown(rawMarkdown)) {
        const hsConfigFileBlocksWithContext = await (0, markdown_parser_1.parseCodeBlocksFromMarkdown)(file, sink);
        for (const { data, codeBlock } of hsConfigFileBlocksWithContext) {
            // only consider YAML/JSON blocks
            if (!/^(yaml|json)/i.test(codeBlock.info || "")) {
                continue;
            }
            // super-quick JSON block syntax check.
            if (/^(json)/i.test(codeBlock.info || "")) {
                // check syntax on JSON blocks with simple check first
                const error = (0, json_1.validateJson)(await data.readData());
                if (error) {
                    logger.trackError({
                        code: error_codes_1.LiterateYamlErrorCodes.jsonParsingError,
                        message: `Syntax Error Encountered:  ${error.message}`,
                        source: [{ position: await (0, datastore_1.indexToPosition)(data, error.position), document: data.key }],
                    });
                    throw new common_1.OperationAbortedException();
                }
            }
            const ast = await data.readYamlAst();
            // quick syntax check.
            const { errors } = (0, yaml_1.getYamlNodeValue)(ast);
            if (errors.length > 0) {
                for (const { message, position } of errors) {
                    logger.trackError({
                        code: error_codes_1.LiterateYamlErrorCodes.yamlParsingError,
                        message: `Syntax Error Encountered:  ${message}`,
                        source: [{ position: await (0, datastore_1.indexToPosition)(data, position), document: data.key }],
                    });
                }
                throw new common_1.OperationAbortedException();
            }
            hsConfigFileBlocks.push({ info: codeBlock.info, data });
        }
    }
    // fall back to raw YAML
    if (hsConfigFileBlocks.length === 0) {
        hsConfigFileBlocks = [{ info: null, data: file }];
    }
    return hsConfigFileBlocks;
}
exports.parseConfigFile = parseConfigFile;
//# sourceMappingURL=literate-yaml.js.map

/***/ }),

/***/ "../../libs/configuration/dist/literate-yaml/markdown-parser.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

/* eslint-disable @typescript-eslint/no-use-before-define */
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.commonmarkHeadingFollowingText = exports.commonmarkHeadingText = exports.commonmarkSubHeadings = exports.parseCommonmark = exports.parseCodeBlocksFromMarkdown = void 0;
const commonmark = __importStar(__webpack_require__("../../../common/temp/node_modules/.pnpm/commonmark@0.27.0/node_modules/commonmark/lib/index.js"));
/**
 * Retrieve all code blocks in the markdown file
 * @param hConfigFile DataHandle for the markdown config file.
 * @param sink Data sink.
 */
async function parseCodeBlocksFromMarkdown(hConfigFile, sink) {
    const result = [];
    const rawMarkdown = await hConfigFile.readData();
    for (const codeBlock of parseCodeblocks(rawMarkdown)) {
        const codeBlockKey = `codeBlock_${codeBlock.sourcepos[0][0]}`;
        const data = codeBlock.literal || "";
        const mappings = getSourceMapForCodeBlock(hConfigFile.key, codeBlock);
        const hCodeBlock = await sink.writeData(codeBlockKey, data, hConfigFile.identity, undefined, {
            positionMappings: mappings,
        });
        result.push({
            data: hCodeBlock,
            codeBlock,
        });
    }
    return result;
}
exports.parseCodeBlocksFromMarkdown = parseCodeBlocksFromMarkdown;
function getSourceMapForCodeBlock(sourceFileName, codeBlock) {
    const result = new Array();
    const numLines = codeBlock.sourcepos[1][0] - codeBlock.sourcepos[0][0] + (codeBlock.info === null ? 1 : -1);
    for (let i = 0; i < numLines; ++i) {
        result.push({
            generated: {
                line: i + 1,
                column: 1,
            },
            original: {
                line: i + codeBlock.sourcepos[0][0] + (codeBlock.info === null ? 0 : 1),
                column: 1 + codeBlock.sourcepos[0][1] - 1,
            },
            source: sourceFileName,
            name: `Codeblock line '${i + 1}'`,
        });
    }
    return result;
}
function parseCommonmark(markdown) {
    return new commonmark.Parser().parse(markdown);
}
exports.parseCommonmark = parseCommonmark;
function* parseCodeblocks(markdown) {
    const parsed = parseCommonmark(markdown);
    const walker = parsed.walker();
    let event;
    while ((event = walker.next())) {
        const node = event.node;
        if (event.entering && node.type === "code_block") {
            yield node;
        }
    }
}
const commonmarkHeadingNodeType = "heading";
const commonmarkHeadingMaxLevel = 1000;
function* commonmarkSubHeadings(startNode) {
    if (startNode && (startNode.type === commonmarkHeadingNodeType || !startNode.prev)) {
        const currentLevel = startNode.level;
        let maxLevel = commonmarkHeadingMaxLevel;
        startNode = startNode.next;
        while (startNode != null) {
            if (startNode.type === commonmarkHeadingNodeType) {
                if (currentLevel < startNode.level) {
                    if (startNode.level <= maxLevel) {
                        maxLevel = startNode.level;
                        yield startNode;
                    }
                }
                else {
                    break;
                }
            }
            startNode = startNode.next;
        }
    }
}
exports.commonmarkSubHeadings = commonmarkSubHeadings;
function commonmarkHeadingText(headingNode) {
    let text = "";
    let node = headingNode.firstChild;
    while (node) {
        text += node.literal;
        node = node.next;
    }
    return text;
}
exports.commonmarkHeadingText = commonmarkHeadingText;
function commonmarkHeadingFollowingText(headingNode) {
    let subNode = headingNode.next;
    if (subNode === null) {
        throw new Error("No node found after heading node");
    }
    const startPos = subNode.sourcepos[0];
    while (subNode.next &&
        subNode.next.type !== "code_block" &&
        subNode.next.type !== commonmarkHeadingNodeType /* || subNode.next.level > headingNode.level*/) {
        subNode = subNode.next;
    }
    const endPos = subNode.sourcepos[1];
    return [startPos[0], endPos[0]];
}
exports.commonmarkHeadingFollowingText = commonmarkHeadingFollowingText;
//# sourceMappingURL=markdown-parser.js.map

/***/ }),

/***/ "../../libs/configuration/dist/utils.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.getLogLevel = exports.arrayOf = exports.isIterable = void 0;
function isIterable(target) {
    return !!target && typeof target[Symbol.iterator] === "function";
}
exports.isIterable = isIterable;
/**
 * Takes a configuration value that can be either an array, a single value or empty and returns an array with all values.
 * @param value Value to wrap in an array.
 * @returns Array of all the values.
 */
function arrayOf(value) {
    if (value === undefined) {
        return [];
    }
    switch (typeof value) {
        case "string": // Need to do this case as String is iterable.
            return [value];
        case "object":
            if (isIterable(value)) {
                return [...value];
            }
            break;
    }
    return [value];
}
exports.arrayOf = arrayOf;
function getLogLevel(config) {
    var _a;
    return config.debug ? "debug" : config.verbose ? "verbose" : (_a = config.level) !== null && _a !== void 0 ? _a : "information";
}
exports.getLogLevel = getLogLevel;
//# sourceMappingURL=utils.js.map

/***/ }),

/***/ "../../libs/datastore/dist/cancellation.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
//# sourceMappingURL=cancellation.js.map

/***/ }),

/***/ "../../libs/datastore/dist/constants.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.DefaultConfiguration = exports.MagicString = void 0;
exports.MagicString = "\n> see https://aka.ms/autorest";
exports.DefaultConfiguration = "readme.md";
//# sourceMappingURL=constants.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/data-handle.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.DataHandle = void 0;
const fs_1 = __webpack_require__("fs");
const yaml_1 = __webpack_require__("../../libs/yaml/dist/index.js");
const text_utility_1 = __webpack_require__("../../libs/datastore/dist/parsing/text-utility.js");
const source_map_1 = __webpack_require__("../../libs/datastore/dist/source-map/index.js");
class DataHandle {
    /**
     * @param autoUnload If the data unhandle should automatically unload files after they are not used for a while.
     */
    constructor(key, item, autoUnload = true) {
        this.key = key;
        this.item = item;
        this.autoUnload = autoUnload;
        // start the clock once this has been created.
        // this ensures that the data cache will be flushed if not
        // used in a reasonable amount of time
        this.resetUnload();
    }
    async serialize() {
        this.item.name;
        return JSON.stringify({
            key: this.description,
            artifactType: this.item.artifactType,
            identity: this.item.identity,
            name: this.item.name,
            content: await this.readData(true),
        });
    }
    resetUnload() {
        if (this.unloadTimer) {
            clearTimeout(this.unloadTimer);
        }
        if (!this.autoUnload) {
            return;
        }
        setTimeout(() => {
            if (this.item.accessed) {
                this.item.accessed = false;
                this.resetUnload();
            }
            else {
                this.unload();
            }
        }, 3000);
    }
    unload() {
        if (!this.item.writeToDisk) {
            // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
            this.item.writeToDisk = fs_1.promises.writeFile(this.item.name, this.item.cached);
        }
        if (this.item.positionSourceMap) {
            void this.item.positionSourceMap.unload();
        }
        if (this.item.pathSourceMap && this.item.pathSourceMap instanceof source_map_1.PathSourceMap) {
            void this.item.pathSourceMap.unload();
        }
        // clear the caches.
        this.item.status = "unloaded";
        this.item.cached = undefined;
        this.item.cachedObject = undefined;
        this.item.cachedAst = undefined;
    }
    get originalDirectory() {
        const id = this.identity[0];
        return id.substring(0, id.lastIndexOf("/"));
    }
    get originalFullPath() {
        return this.identity[0];
    }
    get identity() {
        return this.item.identity;
    }
    async readData(nocache = false) {
        if (!nocache) {
            // we're going to use the data, so let's not let it expire.
            this.item.accessed = true;
        }
        // if it's not cached, load it from disk.
        if (this.item.cached === undefined) {
            // make sure the write-to-disk is finished.
            await this.item.writeToDisk;
            if (nocache) {
                return await fs_1.promises.readFile(this.item.name, "utf8");
            }
            else {
                this.item.cached = await fs_1.promises.readFile(this.item.name, "utf8");
                this.item.status = "loaded";
                // start the timer again.
                this.resetUnload();
            }
        }
        return this.item.cached;
    }
    async readObject() {
        this.item.accessed = true;
        return this.item.cachedObject || (this.item.cachedObject = (0, yaml_1.parseYAMLFast)(await this.readData()));
    }
    async readYamlAst() {
        // we're going to use the data, so let's not let it expire.
        this.item.accessed = true;
        // return the cachedAst or get it, then return it.
        return this.item.cachedAst || (this.item.cachedAst = (0, yaml_1.parseYAMLAst)(await this.readData()));
    }
    get artifactType() {
        return this.item.artifactType;
    }
    get description() {
        return decodeURIComponent(this.key.split("?").reverse()[0]);
    }
    async isObject() {
        try {
            await this.readObject();
            return true;
        }
        catch (e) {
            return false;
        }
    }
    async blame(position) {
        if ("path" in position && !("line" in position)) {
            return this.blamePath(position.path);
        }
        else {
            if (this.item.positionSourceMap) {
                const mapping = await this.item.positionSourceMap.getOriginalLocation(position);
                if (mapping) {
                    return [mapping];
                }
                else {
                    return [];
                }
            }
        }
        return [];
    }
    async blamePath(path) {
        if (this.item.pathSourceMap) {
            if (this.item.pathSourceMap instanceof source_map_1.IdentityPathMappings) {
                return [{ path, source: this.item.pathSourceMap.source }];
            }
            const mapping = await this.item.pathSourceMap.getOriginalLocation({ path });
            if (mapping) {
                return [mapping];
            }
            else {
                return [];
            }
        }
        const resolvedPosition = await (0, source_map_1.resolvePathPosition)(this, path);
        if (this.item.positionSourceMap) {
            const mapping = await this.item.positionSourceMap.getOriginalLocation(resolvedPosition);
            if (mapping) {
                return [mapping];
            }
            else {
                return [];
            }
        }
        return [{ source: this.key, ...resolvedPosition }];
    }
    async lineIndices() {
        if (!this.item.lineIndices) {
            this.item.lineIndices = (0, text_utility_1.getLineIndices)(await this.readData());
        }
        return this.item.lineIndices;
    }
    /**
     * @deprecated use @see isObject
     */
    async IsObject() {
        return this.isObject();
    }
    /**
     * @deprecated use @see description
     */
    get Description() {
        return this.description;
    }
    /**
     * @deprecated use @see readData
     */
    async ReadData(nocache = false) {
        return this.readData(nocache);
    }
    /**
     * @deprecated use @see readObject
     */
    async ReadObject() {
        return this.readObject();
    }
    /**
     * @deprecated use @see readYamlAst
     */
    async ReadYamlAst() {
        return this.readYamlAst();
    }
}
exports.DataHandle = DataHandle;
//# sourceMappingURL=data-handle.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/data-sink.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.DataSink = void 0;
const yaml_1 = __webpack_require__("../../libs/yaml/dist/index.js");
const source_map_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/source-map@0.7.3/node_modules/source-map/source-map.js");
const source_map_2 = __webpack_require__("../../libs/datastore/dist/source-map/index.js");
class DataSink {
    constructor(write, forward) {
        this.write = write;
        this.forward = forward;
    }
    async writeDataWithSourceMap(description, data, artifact, identity, sourceMapFactory) {
        return this.write(description, data, artifact, identity, undefined, sourceMapFactory);
    }
    async writeData(description, data, identity, artifact, mappings) {
        if (!mappings) {
            return this.write(description, data, artifact, identity);
        }
        if ("pathMappings" in mappings) {
            return this.write(description, data, artifact, identity, mappings === null || mappings === void 0 ? void 0 : mappings.pathMappings);
        }
        return this.write(description, data, artifact, identity, undefined, async (readHandle) => {
            const sourceMapGenerator = new source_map_1.SourceMapGenerator({ file: readHandle.key });
            if (mappings) {
                await (0, source_map_2.addMappingsToSourceMap)(mappings.positionMappings, sourceMapGenerator);
            }
            return sourceMapGenerator.toJSON();
        });
    }
    writeObject(description, obj, identity, artifact, mappings) {
        return this.writeData(description, (0, yaml_1.fastStringify)(obj), identity, artifact, mappings);
    }
}
exports.DataSink = DataSink;
//# sourceMappingURL=data-sink.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/data-source.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.DataSource = void 0;
class DataSource {
    constructor() {
        this.pipeState = {};
    }
    get skip() {
        return !!this.pipeState.skipping;
    }
    get cachable() {
        return !this.pipeState.excludeFromCache;
    }
    set cachable(value) {
        this.pipeState.excludeFromCache = !value;
    }
    async readStrict(uri) {
        const result = await this.read(uri);
        if (result === null) {
            throw new Error(`Could not read '${uri}'.`);
        }
        return result;
    }
    /**
     * @deprecated use @see readStrict
     */
    async ReadStrict(uri) {
        return this.readStrict(uri);
    }
    /**
     *
     * @deprecated use @see enum() instead
     */
    async Enum() {
        return this.enum();
    }
    /**
     *
     * @deprecated use @see read() instead
     */
    async Read(key) {
        return this.read(key);
    }
}
exports.DataSource = DataSource;
//# sourceMappingURL=data-source.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/data-store.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.DataStore = void 0;
const crypto_1 = __webpack_require__("crypto");
const fs_1 = __webpack_require__("fs");
const os_1 = __webpack_require__("os");
const path_1 = __webpack_require__("path");
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const source_map_1 = __webpack_require__("../../libs/datastore/dist/source-map/index.js");
const blaming_1 = __webpack_require__("../../libs/datastore/dist/source-map/blaming.js");
const data_handle_1 = __webpack_require__("../../libs/datastore/dist/data-store/data-handle.js");
const data_sink_1 = __webpack_require__("../../libs/datastore/dist/data-store/data-sink.js");
const read_through_data_source_1 = __webpack_require__("../../libs/datastore/dist/data-store/read-through-data-source.js");
const md5 = (content) => (content ? (0, crypto_1.createHash)("md5").update(JSON.stringify(content)).digest("hex") : null);
const FALLBACK_DEFAULT_OUTPUT_ARTIFACT = "";
class DataStore {
    constructor(options = {}) {
        this.options = options;
        this.BaseUri = DataStore.BaseUri;
        this.store = {};
        /****************
         * Data access
         ***************/
        this.uid = 0;
    }
    async getCacheFolder() {
        if (!this.cacheFolder) {
            this.cacheFolder = await fs_1.promises.mkdtemp((0, path_1.join)((0, os_1.tmpdir)(), "autorest-"));
        }
        return this.cacheFolder;
    }
    getReadThroughScope(fs) {
        return new read_through_data_source_1.ReadThroughDataSource(this, fs);
    }
    async writeData(description, data, artifactType, identity, mappings, sourceMapFactory) {
        const uri = this.createUri(description);
        if (this.store[uri]) {
            throw new Error(`can only write '${uri}' once`);
        }
        // make a sanitized name
        let filename = uri.replace(/[^\w.()]+/g, "-");
        if (filename.length > 64) {
            filename = `${md5(filename)}-${filename.substr(filename.length - 64)}`;
        }
        const name = (0, path_1.join)(await this.getCacheFolder(), filename);
        const item = {
            status: "loaded",
            name,
            cached: data,
            artifactType,
            identity,
            pathSourceMap: undefined,
            positionSourceMap: undefined,
        };
        const handle = (this.store[uri] = new data_handle_1.DataHandle(uri, item, this.options.autoUnloadData));
        if (sourceMapFactory) {
            item.positionSourceMap = new source_map_1.PositionSourceMap(name, await sourceMapFactory(handle));
        }
        if (mappings) {
            item.pathSourceMap = mappings instanceof source_map_1.IdentityPathMappings ? mappings : new source_map_1.PathSourceMap(name, mappings);
        }
        return handle;
    }
    createUri(description) {
        return (0, uri_1.resolveUri)(this.BaseUri, `${this.uid++}?${encodeURIComponent(description)}`);
    }
    getDataSink(defaultArtifact = FALLBACK_DEFAULT_OUTPUT_ARTIFACT) {
        return new data_sink_1.DataSink((description, data, artifact, identity, mappings, sourceMapFactory) => this.writeData(description, data, artifact || defaultArtifact, identity, mappings, sourceMapFactory), async (description, input) => {
            const uri = this.createUri(description);
            this.store[uri] = this.store[input.key];
            return this.read(uri);
        });
    }
    readStrictSync(absoluteUri) {
        const entry = this.store[absoluteUri];
        if (entry === undefined) {
            throw new Error(`Object '${absoluteUri}' does not exist.`);
        }
        return entry;
    }
    async read(uri) {
        uri = (0, uri_1.resolveUri)(this.BaseUri, uri);
        const data = this.store[uri];
        if (!data) {
            throw new Error(`Could not read '${uri}'.`);
        }
        return data;
    }
    async blame(absoluteUri, position) {
        return await blaming_1.BlameTree.create(this, {
            source: absoluteUri,
            ...position,
        });
    }
    /**
     * @deprecated use @see getReadThroughScope
     */
    GetReadThroughScope(fs) {
        return this.getReadThroughScope(fs);
    }
    /**
     * @deprecated use @see writeData
     */
    async WriteData(description, data, artifact, identity, sourceMapFactory) {
        return this.writeData(description, data, artifact, identity, undefined, sourceMapFactory);
    }
    /**
     * @deprecated use @see readStrictSync
     */
    ReadStrictSync(absoluteUri) {
        return this.readStrictSync(absoluteUri);
    }
    /**
     * @deprecated use @see read
     */
    async Read(uri) {
        return this.read(uri);
    }
    /**
     * @deprecated use @see blame
     */
    async Blame(absoluteUri, position) {
        return this.blame(absoluteUri, position);
    }
}
exports.DataStore = DataStore;
DataStore.BaseUri = "mem://";
//# sourceMappingURL=data-store.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/datastore/dist/data-store/data-handle.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/data-store/data-source.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/data-store/data-sink.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/data-store/data-store.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/data-store/misc.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/data-store/quick-data-source.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/misc.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.mergePipeStates = void 0;
function mergePipeStates(result, ...pipeStates) {
    for (const each of pipeStates) {
        result.skipping === undefined ? each.skipping : result.skipping && each.skipping;
        result.excludeFromCache === undefined ? each.excludeFromCache : result.excludeFromCache || each.excludeFromCache;
    }
    return result;
}
exports.mergePipeStates = mergePipeStates;
//# sourceMappingURL=misc.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/quick-data-source.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.QuickDataSource = void 0;
const data_source_1 = __webpack_require__("../../libs/datastore/dist/data-store/data-source.js");
class QuickDataSource extends data_source_1.DataSource {
    constructor(handles, pipeState) {
        super();
        this.handles = handles;
        this.pipeState = pipeState || {};
    }
    async enum() {
        return this.pipeState.skipping ? new Array() : this.handles.map((x) => x.key);
    }
    async read(key) {
        if (this.pipeState.skipping) {
            return null;
        }
        const data = this.handles.filter((x) => x.key === key)[0];
        return data || null;
    }
}
exports.QuickDataSource = QuickDataSource;
//# sourceMappingURL=quick-data-source.js.map

/***/ }),

/***/ "../../libs/datastore/dist/data-store/read-through-data-source.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ReadThroughDataSource = void 0;
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const logger_1 = __webpack_require__("../../libs/datastore/dist/logger.js");
const data_source_1 = __webpack_require__("../../libs/datastore/dist/data-store/data-source.js");
class ReadThroughDataSource extends data_source_1.DataSource {
    constructor(store, fs) {
        super();
        this.store = store;
        this.fs = fs;
        this.uris = [];
        this.cache = {};
    }
    get cachable() {
        // filesystem based data source can't cache
        return false;
    }
    async read(uri) {
        // sync cache (inner stuff is racey!)
        if (!this.cache[uri]) {
            this.cache[uri] = (async () => {
                // probe data store
                try {
                    const existingData = await this.store.Read(uri);
                    this.uris.push(uri);
                    return existingData;
                }
                catch (e) {
                    // ignore .
                }
                // populate cache
                let data = null;
                try {
                    data = (await this.fs.read(uri)) || (await (0, uri_1.readUri)(uri));
                    if (data) {
                        const parent = (0, uri_1.parentFolderUri)(uri) || "";
                        // hack to let $(this-folder) resolve to the location...
                        data = data.replace(/\$\(this-folder\)\/*/g, parent);
                    }
                }
                catch (e) {
                    logger_1.logger.error("Unexpected error trying to read file", e);
                }
                finally {
                    if (!data) {
                        // eslint-disable-next-line no-unsafe-finally
                        return null;
                    }
                }
                const readHandle = await this.store.WriteData(uri, data, "input-file", [uri]);
                this.uris.push(uri);
                return readHandle;
            })();
        }
        return this.cache[uri];
    }
    async enum() {
        return this.uris;
    }
}
exports.ReadThroughDataSource = ReadThroughDataSource;
//# sourceMappingURL=read-through-data-source.js.map

/***/ }),

/***/ "../../libs/datastore/dist/file-system/caching-file-system.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.CachingFileSystem = void 0;
class CachingFileSystem {
    constructor(actualFileSystem) {
        this.actualFileSystem = actualFileSystem;
        this.cache = new Map();
    }
    list(folderUri) {
        return this.actualFileSystem.list(folderUri);
    }
    async read(uri) {
        const content = this.cache.get(uri);
        if (content !== undefined) {
            if (typeof content === "string") {
                return content;
            }
            throw content;
        }
        try {
            const data = await this.actualFileSystem.read(uri);
            this.cache.set(uri, data);
            return data;
        }
        catch (error) {
            // not available, but remember that.
            this.cache.set(uri, error);
            throw error;
        }
    }
    /**
     * @deprecated
     */
    EnumerateFileUris(folderUri) {
        return this.list(folderUri);
    }
    /**
     * @deprecated
     */
    async ReadFile(uri) {
        return this.read(uri);
    }
}
exports.CachingFileSystem = CachingFileSystem;
//# sourceMappingURL=caching-file-system.js.map

/***/ }),

/***/ "../../libs/datastore/dist/file-system/enhanced-file-system.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.EnhancedFileSystem = void 0;
const url_1 = __webpack_require__("url");
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const logger_1 = __webpack_require__("../../libs/datastore/dist/logger.js");
const real_file_system_1 = __webpack_require__("../../libs/datastore/dist/file-system/real-file-system.js");
// handles:
// - GitHub URI adjustment
// - GitHub auth
/**
 *
 */
class EnhancedFileSystem extends real_file_system_1.RealFileSystem {
    constructor(githubAuthToken) {
        super();
        this.githubAuthToken = githubAuthToken;
    }
    async read(uri) {
        return super.read(uri, this.getHeaders(uri));
    }
    async write(uri, content) {
        return (0, uri_1.writeString)(uri, content);
    }
    getHeaders(uri) {
        const headers = {};
        // check for GitHub OAuth token
        if (this.githubAuthToken && this.isGithubUrl(uri)) {
            logger_1.logger.info(`Used GitHub authentication token to request '${uri}'.`);
            headers.authorization = `Bearer ${this.githubAuthToken}`;
        }
        return headers;
    }
    isGithubUrl(uri) {
        try {
            const url = new url_1.URL(uri);
            return url.host === "raw.githubusercontent.com" || url.host === "github.com";
        }
        catch (_a) {
            return false;
        }
    }
}
exports.EnhancedFileSystem = EnhancedFileSystem;
//# sourceMappingURL=enhanced-file-system.js.map

/***/ }),

/***/ "../../libs/datastore/dist/file-system/errors.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.UriNotFoundError = exports.FileSystemError = void 0;
class FileSystemError extends Error {
}
exports.FileSystemError = FileSystemError;
/**
 * Error representing a uri not found.
 */
class UriNotFoundError extends FileSystemError {
    constructor(uri, message) {
        super(message !== null && message !== void 0 ? message : `${uri} not found.`);
        this.uri = uri;
    }
}
exports.UriNotFoundError = UriNotFoundError;
//# sourceMappingURL=errors.js.map

/***/ }),

/***/ "../../libs/datastore/dist/file-system/file-system.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
//# sourceMappingURL=file-system.js.map

/***/ }),

/***/ "../../libs/datastore/dist/file-system/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/datastore/dist/file-system/caching-file-system.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/file-system/enhanced-file-system.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/file-system/errors.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/file-system/file-system.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/file-system/memory-file-system.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/file-system/real-file-system.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/datastore/dist/file-system/memory-file-system.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.MemoryFileSystem = void 0;
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const errors_1 = __webpack_require__("../../libs/datastore/dist/file-system/errors.js");
class MemoryFileSystem {
    constructor(files) {
        this.outputs = new Map();
        this.filesByUri = new Map([...files.entries()].map(([uri, content]) => [(0, uri_1.ResolveUri)(MemoryFileSystem.DefaultVirtualRootUri, uri), content]));
    }
    async read(uri) {
        const content = this.filesByUri.get(uri);
        if (content === undefined) {
            throw new errors_1.UriNotFoundError(uri, `File ${uri} is not in the MemoryFileSystem`);
        }
        return content;
    }
    async list(folderUri = MemoryFileSystem.DefaultVirtualRootUri) {
        return [...this.filesByUri.keys()].filter((uri) => {
            // in folder?
            if (!uri.startsWith(folderUri)) {
                return false;
            }
            return uri.substr(folderUri.length).indexOf("/") === -1;
        });
    }
    async write(uri, content) {
        this.outputs.set(uri, content);
    }
    /**
     * @deprecated
     */
    async ReadFile(uri) {
        return this.read(uri);
    }
    /**
     * @deprecated
     */
    async EnumerateFileUris(folderUri = MemoryFileSystem.DefaultVirtualRootUri) {
        return this.list(folderUri);
    }
}
exports.MemoryFileSystem = MemoryFileSystem;
MemoryFileSystem.DefaultVirtualRootUri = "file:///";
//# sourceMappingURL=memory-file-system.js.map

/***/ }),

/***/ "../../libs/datastore/dist/file-system/real-file-system.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.KnownUriErrorCode = exports.readUriWithRetries = exports.RealFileSystem = void 0;
const uri_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/uri@3.1.1/node_modules/@azure-tools/uri/dist/index.js");
const Constants = __importStar(__webpack_require__("../../libs/datastore/dist/constants.js"));
const logger_1 = __webpack_require__("../../libs/datastore/dist/logger.js");
const errors_1 = __webpack_require__("../../libs/datastore/dist/file-system/errors.js");
class RealFileSystem {
    constructor() { }
    list(folderUri) {
        return (0, uri_1.enumerateFiles)(folderUri, [Constants.DefaultConfiguration]);
    }
    async read(uri, headers = {}) {
        return await readUriWithRetries(uri, headers);
    }
    async write(uri, content) {
        return (0, uri_1.writeString)(uri, content);
    }
    /**
     * @deprecated
     */
    async ReadFile(uri) {
        return this.read(uri);
    }
    /**
     * @deprecated
     */
    async EnumerateFileUris(folderUri) {
        return this.list(folderUri);
    }
}
exports.RealFileSystem = RealFileSystem;
const MAX_RETRY_COUNT = 3;
/**
 * ReadUri with retries in the case of a remote url and retryable http error.
 * @param uri uri
 * @param headers optional headers for the request.
 */
async function readUriWithRetries(uri, headers = {}) {
    let tryed = 1;
    for (;;) {
        try {
            return await (0, uri_1.readUri)(uri, headers);
        }
        catch (e) {
            tryed++;
            if (isRetryableStatusCode(e.statusCode) && tryed <= MAX_RETRY_COUNT) {
                // eslint-disable-next-line no-console
                logger_1.logger.error(`Failed to load uri ${uri}, trying again (${tryed}/${MAX_RETRY_COUNT})`, e);
            }
            else {
                throw processError(uri, e);
            }
        }
    }
}
exports.readUriWithRetries = readUriWithRetries;
exports.KnownUriErrorCode = {
    NotFound: "ENOTFOUND",
};
/**
 * @param statusCode Error status code.
 * @returns Boolean if this request should be retried.
 */
function isRetryableStatusCode(statusCode) {
    return statusCode >= 500 || statusCode === 0;
}
/**
 * Convert external errors into known error types when able.
 * @param uri Uri that was loaded.
 * @param error Error.
 * @returns new error if error is known or the same error otherwise.
 */
function processError(uri, error) {
    if (isCodeError(error)) {
        if (error.code === exports.KnownUriErrorCode.NotFound) {
            return new errors_1.UriNotFoundError(uri, `${uri} is not found: ${error.message}`);
        }
    }
    return error;
}
function isCodeError(error) {
    return typeof error === "object" && error != null && "code" in error && error["code"] != null;
}
//# sourceMappingURL=real-file-system.js.map

/***/ }),

/***/ "../../libs/datastore/dist/graph-builder.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.createGraphProxy = void 0;
const json_1 = __webpack_require__("../../libs/json/dist/index.js");
const tasks_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/tasks@3.0.255/node_modules/@azure-tools/tasks/dist/main.js");
const source_map_1 = __webpack_require__("../../libs/datastore/dist/source-map/source-map.js");
function createGraphProxy(originalFileName, targetPointer = "", mappings = new Array(), instance = {}) {
    const tag = (value, filename, pointer, key, subject, recurse) => {
        (0, source_map_1.createAssignmentMapping)(value, filename, (0, json_1.parseJsonPointer)(pointer).filter((each) => each !== ""), [...(0, json_1.parseJsonPointer)(targetPointer), key].filter((each) => each !== ""), subject || "", recurse, mappings);
    };
    const push = (value) => {
        instance.push(value.value);
        const filename = value.filename || originalFileName;
        if (!filename) {
            throw new Error("Assignment: filename must be specified when there is no default.");
        }
        const pp = value.pointer ? (0, json_1.parseJsonPointer)(value.pointer) : [];
        const q = parseInt(pp[pp.length - 1], 10);
        if (q >= 0) {
            pp[pp.length - 1] = q;
        }
        (0, source_map_1.createAssignmentMapping)(value.value, filename, pp, [...(0, json_1.parseJsonPointer)(targetPointer).filter((each) => each !== ""), instance.length - 1].filter((each) => each !== ""), value.subject || "", value.recurse, mappings);
    };
    const rewrite = (key, value) => {
        instance[key] = value;
    };
    return new Proxy(instance, {
        get(target, key) {
            switch (key) {
                case "__push__":
                    return push;
                case "__rewrite__":
                    return rewrite;
            }
            return instance[key];
        },
        set(target, key, value) {
            // check if this is a correct assignment.
            if (value.value === undefined) {
                throw new Error(`Assignment: Value '${String(key)}' may not be undefined.`);
            }
            if (value.pointer === undefined) {
                throw new Error(`Assignment: for '${String(key)}', a json pointer property is required.`);
            }
            if (instance[key]) {
                throw new tasks_1.Exception(`Collision detected inserting into object: ${String(key)}`); //-- ${JSON.stringify(instance, null, 2)}
            }
            const filename = value.filename || originalFileName;
            if (!filename) {
                throw new Error("Assignment: filename must be specified when there is no default.");
            }
            instance[key] = value.value;
            tag(value.value, filename, value.pointer, typeof key === "symbol" ? String(key) : key, value.subject, value.recurse ? true : false);
            return true;
        },
    });
}
exports.createGraphProxy = createGraphProxy;
//# sourceMappingURL=graph-builder.js.map

/***/ }),

/***/ "../../libs/datastore/dist/json-path/json-path.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.matches = exports.CreateObject = exports.IsPrefix = exports.selectNodes = exports.nodes = exports.paths = exports.stringify = exports.parse = void 0;
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
const codegen_1 = __webpack_require__("../../libs/codegen/dist/index.js");
const jsonpath_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/jsonpath@1.0.0/node_modules/jsonpath/jsonpath.min.js"));
const safeEval = (0, codegen_1.createSandbox)();
// patch in smart filter expressions
const handlers = jsonpath_1.default.handlers;
handlers.register("subscript-descendant-filter_expression", function (component, partial, count) {
    const src = component.expression.value.slice(1);
    const passable = function (key, value) {
        try {
            return safeEval(src.replace(/@/g, "$$$$"), { $$: value });
        }
        catch (e) {
            return false;
        }
    };
    return eval("this").traverse(partial, null, passable, count);
});
handlers.register("subscript-child-filter_expression", function (component, partial, count) {
    const src = component.expression.value.slice(1);
    const passable = function (key, value) {
        try {
            return safeEval(src.replace(/@/g, "$$$$"), { $$: value });
        }
        catch (e) {
            return false;
        }
    };
    return eval("this").descend(partial, null, passable, count);
});
function parse(jsonPath) {
    return jsonpath_1.default
        .parse(jsonPath)
        .map((part) => part.expression.value)
        .slice(1);
}
exports.parse = parse;
function stringify(jsonPath) {
    return jsonpath_1.default.stringify(["$"].concat(jsonPath));
}
exports.stringify = stringify;
function paths(obj, jsonQuery) {
    return nodes(obj, jsonQuery).map((x) => x.path);
}
exports.paths = paths;
function nodes(obj, jsonQuery) {
    // jsonpath only accepts objects
    if (obj instanceof Object) {
        let result = jsonpath_1.default.nodes(obj, jsonQuery).map((x) => ({ path: x.path.slice(1), value: x.value }));
        const comp = (a, b) => (a < b ? -1 : a > b ? 1 : 0);
        result = result.sort((a, b) => comp(JSON.stringify(a.path), JSON.stringify(b.path)));
        result = result.filter((x, i) => i === 0 || JSON.stringify(x.path) !== JSON.stringify(result[i - 1].path));
        return result;
    }
    else {
        return matches(jsonQuery, []) ? [{ path: [], value: obj }] : [];
    }
}
exports.nodes = nodes;
function selectNodes(obj, jsonQuery) {
    // jsonpath only accepts objects
    if (obj instanceof Object) {
        const result = new Array();
        const keys = new Set();
        for (const node of jsonpath_1.default.nodes(obj, jsonQuery)) {
            const p = jsonpath_1.default.stringify(node.path);
            if (!keys.has(p)) {
                keys.add(p);
                result.push({ path: node.path.slice(1), value: node.value, parent: jsonpath_1.default.parent(obj, p) });
            }
        }
        return result;
    }
    else {
        return [];
    }
}
exports.selectNodes = selectNodes;
function IsPrefix(prefix, path) {
    if (prefix.length > path.length) {
        return false;
    }
    for (let i = 0; i < prefix.length; ++i) {
        if (prefix[i] !== path[i]) {
            return false;
        }
    }
    return true;
}
exports.IsPrefix = IsPrefix;
function CreateObject(jsonPath, leafObject) {
    let obj = leafObject;
    for (const jsonPathComponent of jsonPath.slice().reverse()) {
        obj =
            typeof jsonPathComponent === "number"
                ? (() => {
                    // eslint-disable-next-line prefer-spread
                    const result = Array.apply(null, Array(jsonPathComponent + 1));
                    result[jsonPathComponent] = obj;
                    return result;
                })()
                : (() => {
                    const result = {};
                    result[jsonPathComponent] = obj;
                    return result;
                })();
    }
    return obj;
}
exports.CreateObject = CreateObject;
function matches(jsonQuery, jsonPath) {
    // build dummy object from `jsonPath`
    const leafNode = new Object();
    const obj = CreateObject(jsonPath, leafNode);
    // check that `jsonQuery` on that object returns the `leafNode`
    return nodes(obj, jsonQuery).some((res) => res.value === leafNode);
}
exports.matches = matches;
//# sourceMappingURL=json-path.js.map

/***/ }),

/***/ "../../libs/datastore/dist/json-pointer/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/datastore/dist/json-pointer/json-pointer.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/datastore/dist/json-pointer/json-pointer.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.visit = void 0;
const jp = __importStar(__webpack_require__("../../libs/json/dist/index.js"));
function* visit(obj, parentReference = new Array()) {
    if (!obj) {
        return;
    }
    for (const [key, value] of Object.entries(obj)) {
        const reference = [...parentReference, key];
        yield {
            value,
            key,
            pointer: jp.serializeJsonPointer(reference),
            children: visit(value, reference),
            childIterator: () => visit(value, reference),
        };
    }
}
exports.visit = visit;
//# sourceMappingURL=json-pointer.js.map

/***/ }),

/***/ "../../libs/datastore/dist/lazy.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.LazyPromise = exports.Lazy = void 0;
class Lazy {
    constructor(factory) {
        this.factory = factory;
        this.promise = null;
    }
    get Value() {
        if (this.promise === null) {
            this.promise = { obj: this.factory() };
        }
        return this.promise.obj;
    }
}
exports.Lazy = Lazy;
class LazyPromise {
    constructor(factory) {
        this.factory = factory;
        this.promise = null;
    }
    getValue() {
        if (this.promise === null) {
            this.promise = this.factory();
        }
        return this.promise;
    }
    get hasValue() {
        return this.promise !== null;
    }
    then(onfulfilled, onrejected) {
        return this.getValue().then(onfulfilled, onrejected);
    }
}
exports.LazyPromise = LazyPromise;
//# sourceMappingURL=lazy.js.map

/***/ }),

/***/ "../../libs/datastore/dist/logger.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.logger = void 0;
const logger_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure/logger@1.0.2/node_modules/@azure/logger/dist-esm/src/index.js");
exports.logger = (0, logger_1.createClientLogger)("datastore");
//# sourceMappingURL=logger.js.map

/***/ }),

/***/ "../../libs/datastore/dist/main.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.createSandbox = exports.safeEval = exports.LazyPromise = exports.Lazy = void 0;
/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
// export * from "./proxy"
__exportStar(__webpack_require__("../../libs/datastore/dist/file-system/index.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/json-path/json-path.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/json-pointer/index.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/graph-builder.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/mapping-tree/index.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/data-store/index.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/cancellation.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/source-map/index.js"), exports);
var lazy_1 = __webpack_require__("../../libs/datastore/dist/lazy.js");
Object.defineProperty(exports, "Lazy", ({ enumerable: true, get: function () { return lazy_1.Lazy; } }));
Object.defineProperty(exports, "LazyPromise", ({ enumerable: true, get: function () { return lazy_1.LazyPromise; } }));
__exportStar(__webpack_require__("../../libs/datastore/dist/parsing/text-utility.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/processor.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/transformer-via-pointer.js"), exports);
var codegen_1 = __webpack_require__("../../libs/codegen/dist/index.js");
Object.defineProperty(exports, "safeEval", ({ enumerable: true, get: function () { return codegen_1.safeEval; } }));
Object.defineProperty(exports, "createSandbox", ({ enumerable: true, get: function () { return codegen_1.createSandbox; } }));
//# sourceMappingURL=main.js.map

/***/ }),

/***/ "../../libs/datastore/dist/mapping-tree/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/datastore/dist/mapping-tree/mapping-tree.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/datastore/dist/mapping-tree/mapping-tree.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.createMappingTree = exports.NoMapping = void 0;
const json_1 = __webpack_require__("../../libs/json/dist/index.js");
const tasks_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/tasks@3.0.255/node_modules/@azure-tools/tasks/dist/main.js");
/**
 * To explicitly specify that there is no mapping for this.
 */
exports.NoMapping = Symbol("NoMapping");
/**
 * Create a proxy tree
 * @param sourceFilename Name of the source file that this tree is being constructed from.
 * @param value Initial value
 * @param mappings List of mappings that will get populated as the tree gets built.
 * @param targetPointer Base pointer for this tree.
 * @returns
 */
function createMappingTree(sourceFilename, value, mappings, targetPointer = "") {
    const targetPointerPath = typeof targetPointer === "string" ? (0, json_1.parseJsonPointer)(targetPointer) : targetPointer;
    return proxyDeepObject(sourceFilename, targetPointerPath, value, mappings);
}
exports.createMappingTree = createMappingTree;
function proxyDeepObject(originalFileName, targetPointer, obj, mappings) {
    if (obj === undefined || obj === null) {
        return obj;
    }
    if (Array.isArray(obj)) {
        const proxiedItems = obj.map((x, i) => proxyDeepObject(originalFileName, targetPointer.concat(i), x, mappings));
        return proxyObject(originalFileName, targetPointer, proxiedItems, mappings);
    }
    else if (typeof obj === "object") {
        const result = {};
        for (const [key, value] of Object.entries(obj)) {
            result[key] = proxyDeepObject(originalFileName, targetPointer.concat(key), value, mappings);
        }
        return proxyObject(originalFileName, targetPointer, result, mappings);
    }
    else {
        return obj;
    }
}
function proxyObject(originalFileName, targetPointer = "", value, mappings = new Array()) {
    const targetPointerPath = typeof targetPointer === "string" ? (0, json_1.parseJsonPointer)(targetPointer) : targetPointer;
    const instance = value;
    const push = (value) => {
        const filename = value.sourceFilename || originalFileName;
        if (!filename) {
            throw new Error("Assignment: filename must be specified when there is no default.");
        }
        const newPropertyPath = [...targetPointerPath, instance.length];
        const item = proxyDeepObject(originalFileName, newPropertyPath, value.value, mappings);
        instance.push(item);
        if (value.sourcePointer !== exports.NoMapping) {
            tag(newPropertyPath, filename, parseJsonPointerForArray(value.sourcePointer), mappings);
        }
        return item;
    };
    const rewrite = (key, value) => {
        instance[key] = value;
    };
    const set = (key, value) => {
        // check if this is a correct assignment.
        if (value.value === undefined) {
            throw new Error(`Assignment: Value '${String(key)}' may not be undefined.`);
        }
        if (Object.prototype.hasOwnProperty.call(instance, key)) {
            throw new tasks_1.Exception(`Collision detected inserting into object: ${String(key)}`); //-- ${JSON.stringify(instance, null, 2)}
        }
        const filename = value.sourceFilename || originalFileName;
        if (!filename) {
            throw new Error("Assignment: filename must be specified when there is no default.");
        }
        const newPropertyPath = [...targetPointerPath, typeof key === "symbol" ? String(key) : key];
        instance[key] = proxyDeepObject(originalFileName, newPropertyPath, value.value, mappings);
        if (value.sourcePointer !== exports.NoMapping) {
            tag(newPropertyPath, filename, (0, json_1.parseJsonPointer)(value.sourcePointer), mappings);
        }
        return true;
    };
    return new Proxy(instance, {
        get(_, key) {
            switch (key) {
                case "__push__":
                    return push;
                case "__rewrite__":
                    return rewrite;
                case "__set__":
                    return set;
            }
            return instance[key];
        },
        set(_, key, value) {
            throw new Error(`Use __set__ or __push__ to modify proxy graph. Trying to set ${String(key)} with value: ${value}`);
        },
    });
}
function tag(targetPointerPath, sourceFilename, sourcePointerPath, mappings) {
    mappings.push({
        source: sourceFilename,
        original: sourcePointerPath.filter((each) => each !== ""),
        generated: targetPointerPath.filter((each) => each !== ""),
    });
}
/**
 * Parse the json pointer and try to convert the last segement to a number if applicable.
 * @param pointer Json Pointer to parse
 * @returns Json Path
 */
function parseJsonPointerForArray(pointer) {
    const pp = pointer ? (0, json_1.parseJsonPointer)(pointer) : [];
    const q = parseInt(pp[pp.length - 1], 10);
    if (q >= 0) {
        pp[pp.length - 1] = q;
    }
    return pp;
}
//# sourceMappingURL=mapping-tree.js.map

/***/ }),

/***/ "../../libs/datastore/dist/parsing/text-utility.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.indexToPositionFromLineIndices = exports.indexToPosition = exports.indexToPositionInText = exports.Lines = exports.getLineIndices = void 0;
const regexNewLine = /\r?\n/g;
/**
 * Return an array containg the indexes where each line start. Each cell has the index to its coresponding line.
 * @param text Text to index.
 */
function getLineIndices(text) {
    const indices = [0];
    let match;
    while ((match = regexNewLine.exec(text)) !== null) {
        indices.push(match.index + match[0].length);
    }
    return indices;
}
exports.getLineIndices = getLineIndices;
function Lines(text) {
    return text.split(regexNewLine);
}
exports.Lines = Lines;
/**
 * Retrieve the position(Line,Column) from the index in the source.
 * @param text Source.
 * @param index Index.
 */
function indexToPositionInText(text, index) {
    return indexToPositionFromLineIndices(getLineIndices(text), index);
}
exports.indexToPositionInText = indexToPositionInText;
/**
 * Retrieve the position(Line,Column) from the index in the source.
 * @param text Source.
 * @param index Index.
 */
async function indexToPosition(text, index) {
    return indexToPositionFromLineIndices(await text.lineIndices(), index);
}
exports.indexToPosition = indexToPosition;
/**
 * Retrieve the position(Line,Column) from the index in the source.
 * @param text Source.
 * @param index Index.
 */
function indexToPositionFromLineIndices(startIndices, index) {
    // bin. search for last `<item> <= index`
    let lineIndexMin = 0;
    let lineIndexMax = startIndices.length;
    while (lineIndexMin < lineIndexMax - 1) {
        const lineIndex = ((lineIndexMin + lineIndexMax) / 2) | 0;
        if (startIndices[lineIndex] <= index) {
            lineIndexMin = lineIndex;
        }
        else {
            lineIndexMax = lineIndex;
        }
    }
    return {
        column: 1 + index - startIndices[lineIndexMin],
        line: 1 + lineIndexMin,
    };
}
exports.indexToPositionFromLineIndices = indexToPositionFromLineIndices;
//# sourceMappingURL=text-utility.js.map

/***/ }),

/***/ "../../libs/datastore/dist/processor.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.typeOf = exports.Processor = exports.Transformer = void 0;
const json_1 = __webpack_require__("../../libs/json/dist/index.js");
const lodash_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/lodash@4.17.21/node_modules/lodash/lodash.js");
const main_1 = __webpack_require__("../../libs/datastore/dist/main.js");
class Transformer {
    constructor(inputs) {
        this.mappings = new Array();
        this.targetPointers = new Map();
        this.generated = (0, main_1.createGraphProxy)("", "", this.mappings);
        this.targetPointers.set(this.generated, "");
        this.inputs = Array.isArray(inputs) ? inputs : [inputs];
    }
    async getOutput() {
        await this.runProcess();
        return this.final;
    }
    async getSourceMappings() {
        await this.runProcess();
        return this.mappings;
    }
    // public process(input: string, parent: ProxyObject<TOutput>, nodes: Iterable<NodeT<TInput, keyof TInput>>) {
    async process(target, nodes) {
        /* override this method */
    }
    async init() {
        /* override this method */
    }
    async finish() {
        /* override this method */
    }
    getOrCreateObject(target, member, pointer) {
        return target[member] === undefined ? this.newObject(target, member, pointer) : target[member];
    }
    getOrCreateArray(target, member, pointer) {
        return target[member] === undefined ? this.newArray(target, member, pointer) : target[member];
    }
    newObject(target, member, pointer) {
        var _a;
        const parentTargetPointer = (0, json_1.parseJsonPointer)((_a = this.targetPointers.get(target)) !== null && _a !== void 0 ? _a : "");
        const targetPointer = (0, json_1.serializeJsonPointer)([...parentTargetPointer, member]);
        const value = (0, main_1.createGraphProxy)(this.currentInputFilename, targetPointer, this.mappings);
        this.targetPointers.set(value, targetPointer);
        target[member] = {
            value: value,
            filename: this.currentInputFilename,
            pointer,
        };
        return value;
    }
    newArray(target, member, pointer) {
        var _a;
        const parentTargetPointer = (0, json_1.parseJsonPointer)((_a = this.targetPointers.get(target)) !== null && _a !== void 0 ? _a : "");
        const targetPointer = (0, json_1.serializeJsonPointer)([...parentTargetPointer, member]);
        const value = ((0, main_1.createGraphProxy)(this.currentInputFilename, targetPointer, this.mappings, new Array()));
        this.targetPointers.set(value, targetPointer);
        target[member] = {
            value: value,
            filename: this.currentInputFilename,
            pointer,
        };
        return value;
    }
    copy(target, member, pointer, value, recurse = true) {
        return (target[member] = { value, pointer, recurse, filename: this.currentInputFilename });
    }
    clone(target, member, pointer, value, recurse = true) {
        // return target[member] = <ProxyNode<TParent[K]>>{ value: JSON.parse(JSON.stringify(value)), pointer, recurse, filename: this.key };
        return (target[member] = {
            value: (0, lodash_1.cloneDeep)(value),
            pointer,
            recurse,
            filename: this.currentInputFilename,
        });
    }
    get currentInputFilename() {
        if (this.currentInput) {
            return this.currentInput.key;
        }
        // default to the first document if we haven't started processing yet.
        return this.inputs[0].key;
    }
    async runProcess() {
        if (!this.final) {
            await this.init();
            for (this.currentInput of this.inputs) {
                this.current = await this.currentInput.ReadObject();
                await this.process(this.generated, (0, main_1.visit)(this.current));
            }
            await this.finish();
        }
        this.final = (0, lodash_1.cloneDeep)(this.generated); // should we be freezing this?
    }
}
exports.Transformer = Transformer;
class Processor extends Transformer {
    constructor(originalFile) {
        super([originalFile]);
    }
}
exports.Processor = Processor;
function typeOf(obj) {
    if (obj === null) {
        return "null";
    }
    const t = typeof obj;
    return t === "object" ? (Array.isArray(obj) ? "array" : "object") : t;
}
exports.typeOf = typeOf;
//# sourceMappingURL=processor.js.map

/***/ }),

/***/ "../../libs/datastore/dist/source-map/blaming.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.BlameTree = void 0;
const lodash_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/lodash@4.17.21/node_modules/lodash/lodash.js");
/**
 * Represent a source mapping tree.
 */
class BlameTree {
    constructor(node, blaming) {
        this.node = node;
        this.blaming = blaming;
    }
    static async create(dataStore, position) {
        const data = dataStore.readStrictSync(position.source);
        const blames = await data.blame(position);
        const children = [];
        for (const pos of blames) {
            children.push(await BlameTree.create(dataStore, pos));
        }
        return new BlameTree(position, children);
    }
    /**
     * @returns List of mapped positions at the leaf of the tree.(i.e. the original file(s) posistions)
     */
    getMappingLeafs() {
        const result = [];
        const todos = [this];
        let todo;
        while ((todo = todos.pop())) {
            // report self
            if (todo.blaming.length === 0) {
                if ("line" in todo.node) {
                    result.push({
                        column: todo.node.column,
                        line: todo.node.line,
                        source: todo.node.source,
                    });
                }
            }
            // recurse
            todos.push(...todo.blaming);
        }
        // Return distrinct values.
        return (0, lodash_1.uniqBy)(result, (x) => JSON.stringify(x));
    }
}
exports.BlameTree = BlameTree;
//# sourceMappingURL=blaming.js.map

/***/ }),

/***/ "../../libs/datastore/dist/source-map/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/datastore/dist/source-map/blaming.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/source-map/source-map.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/source-map/path-source-map.js"), exports);
__exportStar(__webpack_require__("../../libs/datastore/dist/source-map/position-source-map.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/datastore/dist/source-map/path-source-map.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.PathSourceMapData = exports.PathSourceMap = exports.IdentityPathMappings = void 0;
const json_1 = __webpack_require__("../../libs/json/dist/index.js");
const source_map_data_1 = __webpack_require__("../../libs/datastore/dist/source-map/source-map-data.js");
/**
 * PathSourceMap where the path between the source and generated documeent are a 1:1 mapping.
 * To use when a plugin doesn't change the structure.
 */
class IdentityPathMappings {
    constructor(source) {
        this.source = source;
    }
}
exports.IdentityPathMappings = IdentityPathMappings;
/**
 * Sourcemap based on json paths.
 */
class PathSourceMap {
    constructor(filename, mappings) {
        const map = new Map();
        for (const mapping of mappings) {
            map.set((0, json_1.serializeJsonPointer)(mapping.generated), { path: mapping.original, source: mapping.source });
        }
        this.data = new PathSourceMapData(`${filename}.pathmap`, map);
    }
    async getOriginalLocation(position) {
        const mappings = await this.data.get();
        const path = typeof position.path === "string" ? position.path : (0, json_1.serializeJsonPointer)(position.path);
        const mapping = mappings.get(path);
        if (!mapping) {
            return undefined;
        }
        return mapping;
    }
    unload() {
        return this.data.unload();
    }
}
exports.PathSourceMap = PathSourceMap;
class PathSourceMapData extends source_map_data_1.SourceMapData {
    serialize(value) {
        return JSON.stringify([...value]);
    }
    parse(content) {
        return new Map(JSON.parse(content));
    }
}
exports.PathSourceMapData = PathSourceMapData;
//# sourceMappingURL=path-source-map.js.map

/***/ }),

/***/ "../../libs/datastore/dist/source-map/position-source-map.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.PositionSourceMapData = exports.PositionSourceMap = void 0;
const source_map_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/source-map@0.7.3/node_modules/source-map/source-map.js");
const source_map_data_1 = __webpack_require__("../../libs/datastore/dist/source-map/source-map-data.js");
/**
 * Sourcemap based on json paths.
 */
class PositionSourceMap {
    constructor(filename, mappings) {
        this.data = new PositionSourceMapData(`${filename}.map`, mappings);
    }
    async getOriginalLocation(position) {
        const sourceMap = await this.data.get();
        const consumer = await new source_map_1.SourceMapConsumer(sourceMap);
        const mappedPosition = consumer.originalPositionFor(position);
        if (mappedPosition.line === null) {
            return undefined;
        }
        return mappedPosition;
    }
    unload() {
        return this.data.unload();
    }
}
exports.PositionSourceMap = PositionSourceMap;
class PositionSourceMapData extends source_map_data_1.SourceMapData {
    serialize(value) {
        return JSON.stringify(value);
    }
    parse(content) {
        return JSON.parse(content);
    }
}
exports.PositionSourceMapData = PositionSourceMapData;
//# sourceMappingURL=position-source-map.js.map

/***/ }),

/***/ "../../libs/datastore/dist/source-map/source-map-data.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.SourceMapData = void 0;
const fs_1 = __importDefault(__webpack_require__("fs"));
/**
 * Abstract class for defining a document sourcemap data with built-in memory unloading functionality.
 */
class SourceMapData {
    constructor(filename, value) {
        this.filename = filename;
        this.data = { value, status: "loaded" };
    }
    async get() {
        if (this.data.status === "unloaded") {
            const value = await this.loadCached();
            this.data = { value, status: "loaded" };
        }
        return this.data.value;
    }
    async unload() {
        if (this.data.status === "unloaded") {
            return;
        }
        const content = this.serialize(this.data.value);
        await fs_1.default.promises.writeFile(this.filename, content);
        this.data = { status: "unloaded" };
    }
    async loadCached() {
        const content = await fs_1.default.promises.readFile(this.filename);
        return this.parse(content.toString());
    }
}
exports.SourceMapData = SourceMapData;
//# sourceMappingURL=source-map-data.js.map

/***/ }),

/***/ "../../libs/datastore/dist/source-map/source-map.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.resolvePathPosition = exports.createAssignmentMapping = exports.addMappingsToSourceMap = void 0;
const json_1 = __webpack_require__("../../libs/json/dist/index.js");
const yaml_1 = __webpack_require__("../../libs/yaml/dist/index.js");
const text_utility_1 = __webpack_require__("../../libs/datastore/dist/parsing/text-utility.js");
async function addMappingsToSourceMap(mappings, target) {
    for (const mapping of mappings) {
        try {
            target.addMapping(mapping);
        }
        catch (_a) {
            // Failed to acquire a mapping for the orignal or generated position(probably means the entry got added or removed) don't do anything.
        }
    }
}
exports.addMappingsToSourceMap = addMappingsToSourceMap;
/** This recursively associates a node in the 'generated' document with a node in the 'source' document
 *
 * @description This does make an implicit assumption that the decendents of the 'generated' node are 1:1 with the descendents in the 'source' node.
 * In the event that is not true, elements in the target's source map will not be pointing to the correct elements in the source node.
 */
function createAssignmentMapping(assignedObject, sourceKey, sourcePath, targetPath, subject, recurse = true, result = []) {
    if (!recurse) {
        result.push({
            source: sourceKey,
            original: sourcePath,
            generated: targetPath,
        });
        return result;
    }
    (0, json_1.walk)(assignedObject, (_, path) => {
        result.push({
            source: sourceKey,
            original: sourcePath.concat(path),
            generated: targetPath.concat(path),
        });
        return "visit-children";
    });
    return result;
}
exports.createAssignmentMapping = createAssignmentMapping;
/**
 * Resolves the text position of a JSON path in raw YAML.
 */
async function resolvePathPosition(yamlFile, jsonPath) {
    const yamlAst = await yamlFile.readYamlAst();
    const node = (0, yaml_1.getYamlNodeByPath)(yamlAst, jsonPath);
    return createEnhancedPosition(yamlFile, jsonPath, node);
}
exports.resolvePathPosition = resolvePathPosition;
async function createEnhancedPosition(yamlFile, jsonPath, node) {
    const startIdx = jsonPath.length === 0 ? 0 : node.startPosition;
    const endIdx = node.endPosition;
    const startPos = await (0, text_utility_1.indexToPosition)(yamlFile, startIdx);
    const endPos = await (0, text_utility_1.indexToPosition)(yamlFile, endIdx);
    const result = { column: startPos.column, line: startPos.line };
    result.path = jsonPath;
    // enhance
    if (node.kind === yaml_1.Kind.MAPPING) {
        const mappingNode = node;
        result.length = mappingNode.key.endPosition - mappingNode.key.startPosition;
        result.valueOffset = mappingNode.value.startPosition - mappingNode.key.startPosition;
        result.valueLength = mappingNode.value.endPosition - mappingNode.value.startPosition;
    }
    else {
        result.length = endIdx - startIdx;
        result.valueOffset = 0;
        result.valueLength = result.length;
    }
    return result;
}
//# sourceMappingURL=source-map.js.map

/***/ }),

/***/ "../../libs/datastore/dist/transformer-via-pointer.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.TransformerViaPointer = void 0;
const processor_1 = __webpack_require__("../../libs/datastore/dist/processor.js");
class TransformerViaPointer extends processor_1.Transformer {
    async process(target, originalNodes) {
        for (const { value, key, pointer, children } of originalNodes) {
            if (!(await this.visitLeaf(target, value, key, pointer, children))) {
                await this.defaultCopy(target, value, key, pointer, children);
            }
        }
    }
    async defaultCopy(target, ivalue, ikey, ipointer, originalNodes) {
        switch ((0, processor_1.typeOf)(ivalue)) {
            case "object":
                {
                    // objects recurse
                    const newTarget = this.newObject(target, ikey, ipointer);
                    for (const { value, key, pointer, children } of originalNodes) {
                        if (!(await this.visitLeaf(newTarget, value, key, pointer, children))) {
                            await this.defaultCopy(newTarget, value, key, pointer, children);
                        }
                    }
                }
                break;
            case "array":
                {
                    const newTarget = this.newArray(target, ikey, ipointer);
                    for (const { value, key, pointer, children } of originalNodes) {
                        if (!(await this.visitLeaf(newTarget, value, key, pointer, children))) {
                            await this.defaultCopy(newTarget, value, key, pointer, children);
                        }
                    }
                }
                break;
            default:
                // everything else, just clone.
                this.clone(target, ikey, ipointer, ivalue);
        }
    }
}
exports.TransformerViaPointer = TransformerViaPointer;
//# sourceMappingURL=transformer-via-pointer.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/exceptions.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ExtensionFolderLocked = exports.MissingStartCommandException = exports.UnsatisfiedSystemRequirementException = exports.UnsatisfiedEngineException = exports.PackageInstallationException = exports.InvalidPackageIdentityException = exports.UnresolvedPackageException = void 0;
class UnresolvedPackageException extends Error {
    constructor(packageId) {
        super(`Unable to resolve package '${packageId}'.`);
        Object.setPrototypeOf(this, UnresolvedPackageException.prototype);
    }
}
exports.UnresolvedPackageException = UnresolvedPackageException;
class InvalidPackageIdentityException extends Error {
    constructor(name, version, message) {
        super(`Package '${name}' - '${version}' is not a valid package reference:\n  ${message}`);
        Object.setPrototypeOf(this, InvalidPackageIdentityException.prototype);
    }
}
exports.InvalidPackageIdentityException = InvalidPackageIdentityException;
class PackageInstallationException extends Error {
    constructor(name, version, message) {
        super(`Package '${name}' - '${version}' failed to install:\n  ${message}`);
        Object.setPrototypeOf(this, PackageInstallationException.prototype);
    }
}
exports.PackageInstallationException = PackageInstallationException;
class UnsatisfiedEngineException extends Error {
    constructor(name, version, message = "") {
        super(`Unable to find matching engine '${name}' - '${version} ${message}'`);
        Object.setPrototypeOf(this, UnsatisfiedEngineException.prototype);
    }
}
exports.UnsatisfiedEngineException = UnsatisfiedEngineException;
class UnsatisfiedSystemRequirementException extends Error {
    constructor(extension, errors) {
        const message = [
            `System is missing dependencies required by extension '${extension.name}':`,
            ...errors.map((x) => ` - ${x.name}: ${x.message.replace(/\n/g, "\n ")}`),
        ].join("\n");
        super(message);
        Object.setPrototypeOf(this, UnsatisfiedSystemRequirementException.prototype);
    }
}
exports.UnsatisfiedSystemRequirementException = UnsatisfiedSystemRequirementException;
class MissingStartCommandException extends Error {
    constructor(extension) {
        super(`Extension '${extension.id}' is missing the script 'start' in the package.json file`);
        Object.setPrototypeOf(this, MissingStartCommandException.prototype);
    }
}
exports.MissingStartCommandException = MissingStartCommandException;
class ExtensionFolderLocked extends Error {
    constructor(path) {
        super(`Extension Folder '${path}' is locked by another process.`);
        Object.setPrototypeOf(this, ExtensionFolderLocked.prototype);
    }
}
exports.ExtensionFolderLocked = ExtensionFolderLocked;
//# sourceMappingURL=exceptions.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/exec-cmd.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.execute = void 0;
const child_process_1 = __webpack_require__("child_process");
const execute = (command, cmdlineargs, options = {}) => {
    return new Promise((resolve, reject) => {
        const cp = (0, child_process_1.spawn)(command, cmdlineargs, { ...options, stdio: "pipe" });
        if (options.onCreate) {
            options.onCreate(cp);
        }
        options.onStdOutData ? cp.stdout.on("data", options.onStdOutData) : cp;
        options.onStdErrData ? cp.stderr.on("data", options.onStdErrData) : cp;
        let err = "";
        let out = "";
        let all = "";
        cp.stderr.on("data", (chunk) => {
            err += chunk;
            all += chunk;
        });
        cp.stdout.on("data", (chunk) => {
            out += chunk;
            all += chunk;
        });
        cp.on("error", (err) => {
            reject(err);
        });
        cp.on("close", (code, signal) => resolve({
            stdout: out,
            stderr: err,
            log: all,
            error: code ? new Error("Process Failed.") : null,
            code,
        }));
    });
};
exports.execute = execute;
//# sourceMappingURL=exec-cmd.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/extension/extension.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.Extension = void 0;
const fs_1 = __webpack_require__("fs");
const path_1 = __webpack_require__("path");
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const package_1 = __webpack_require__("../../libs/extension/dist/src/extension/package.js");
/**
 * Extension is an installed Package
 * @extends Package
 * */
class Extension extends package_1.Package {
    /* @internal */ constructor(pkg, installationPath) {
        super(pkg.resolvedInfo, pkg.packageMetadata, pkg.extensionManager);
        this.installationPath = installationPath;
    }
    /**
     * The installed location of the package.
     */
    get location() {
        return (0, path_1.normalize)(`${this.installationPath}/${this.id.replace("/", "_")}`);
    }
    /**
     * The path to the installed npm package (internal to 'location')
     */
    get modulePath() {
        return (0, path_1.normalize)(`${this.location}/node_modules/${this.name}`);
    }
    /**
     * the path to the package.json file for the npm packge.
     */
    get packageJsonPath() {
        return (0, path_1.normalize)(`${this.modulePath}/package.json`);
    }
    /**
     * the path to the readme.md configuration file for the extension.
     */
    get configurationPath() {
        return (async () => {
            const items = await (0, async_io_1.readdir)(this.modulePath);
            for (const each of items) {
                if (/^readme.md$/i.exec(each)) {
                    const fullPath = (0, path_1.normalize)(`${this.modulePath}/${each}`);
                    if (await (0, async_io_1.isFile)(fullPath)) {
                        return fullPath;
                    }
                }
            }
            return "";
        })();
    }
    /** the loaded package.json information */
    get definition() {
        const content = (0, fs_1.readFileSync)(this.packageJsonPath).toString();
        try {
            return JSON.parse(content);
        }
        catch (e) {
            throw new Error(`Failed to parse package definition at '${this.packageJsonPath}'. ${e}`);
        }
    }
    get configuration() {
        return (async () => {
            const cfgPath = await this.configurationPath;
            if (cfgPath) {
                return (0, async_io_1.readFile)(cfgPath);
            }
            return "";
        })();
    }
    async remove() {
        return this.extensionManager.removeExtension(this);
    }
    async start(enableDebugger = false) {
        return this.extensionManager.start(this, enableDebugger);
    }
}
exports.Extension = Extension;
//# sourceMappingURL=extension.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/extension/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/extension/dist/src/extension/package.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/extension/extension.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/extension/local-extension.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/extension/local-extension.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.LocalExtension = void 0;
const extension_1 = __webpack_require__("../../libs/extension/dist/src/extension/extension.js");
/**
 * LocalExtension is a local extension that must not be installed.
 * @extends Extension
 * */
class LocalExtension extends extension_1.Extension {
    constructor(pkg, extensionPath) {
        super(pkg, "");
        this.extensionPath = extensionPath;
    }
    get location() {
        return this.extensionPath;
    }
    get modulePath() {
        return this.extensionPath;
    }
    async remove() {
        throw new Error("Cannot remove local extension. Lifetime not our responsibility.");
    }
}
exports.LocalExtension = LocalExtension;
//# sourceMappingURL=local-extension.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/extension/package.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.Package = void 0;
/**
 * A Package is a representation of a npm package.
 *
 * Once installed, a Package is an Extension
 */
class Package {
    /* @internal */ constructor(resolvedInfo, 
    /* @internal */ packageMetadata, 
    /* @internal */ extensionManager) {
        this.resolvedInfo = resolvedInfo;
        this.packageMetadata = packageMetadata;
        this.extensionManager = extensionManager;
    }
    get id() {
        // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
        return this.packageMetadata._id;
    }
    get name() {
        return this.packageMetadata.name;
    }
    get version() {
        return this.packageMetadata.version;
    }
    get source() {
        // work around bug that npm doesn't programatically handle exact versions.
        if (this.resolvedInfo.type === "version" && this.resolvedInfo.registry === true) {
            return this.packageMetadata._spec + "*";
        }
        return this.packageMetadata._spec;
    }
    async install(force = false) {
        return this.extensionManager.installPackage(this, force);
    }
    get allVersions() {
        return this.extensionManager.getPackageVersions(this.name);
    }
}
exports.Package = Package;
//# sourceMappingURL=package.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/extension/dist/src/exceptions.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/main.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/extension/index.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/system-requirements/index.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/logger.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.logger = void 0;
const logger_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure/logger@1.0.2/node_modules/@azure/logger/dist-esm/src/index.js");
exports.logger = (0, logger_1.createClientLogger)("@azure-tools/extension");
//# sourceMappingURL=logger.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/main.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ExtensionManager = exports.fetchPackageMetadata = void 0;
const child_process_1 = __webpack_require__("child_process");
const os_1 = __webpack_require__("os");
const path_1 = __webpack_require__("path");
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const tasks_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/tasks@3.0.255/node_modules/@azure-tools/tasks/dist/main.js");
const npm_package_arg_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/npm-package-arg@8.1.5/node_modules/npm-package-arg/npa.js");
const pacote = __importStar(__webpack_require__("../../../common/temp/node_modules/.pnpm/pacote@9.2.3/node_modules/pacote/index.js"));
const semver = __importStar(__webpack_require__("../../../common/temp/node_modules/.pnpm/semver@5.7.1/node_modules/semver/semver.js"));
const exceptions_1 = __webpack_require__("../../libs/extension/dist/src/exceptions.js");
const extension_1 = __webpack_require__("../../libs/extension/dist/src/extension/index.js");
const logger_1 = __webpack_require__("../../libs/extension/dist/src/logger.js");
const npm_1 = __webpack_require__("../../libs/extension/dist/src/npm.js");
const system_requirements_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/index.js");
const yarn_1 = __webpack_require__("../../libs/extension/dist/src/yarn.js");
function quoteIfNecessary(text) {
    if (text && text.indexOf(" ") > -1 && text.charAt(0) != '"') {
        return `"${text}"`;
    }
    return text;
}
const nodePath = quoteIfNecessary(process.execPath);
function cmdlineToArray(text, result = [], matcher = /[^\s"]+|"([^"]*)"/gi, count = 0) {
    text = text.replace(/\\"/g, "\ufffe");
    const match = matcher.exec(text);
    return match
        ? cmdlineToArray(text, result, matcher, result.push(match[1] ? match[1].replace(/\ufffe/g, '\\"') : match[0].replace(/\ufffe/g, '\\"')))
        : result;
}
function getPathVariableName() {
    // windows calls it's path 'Path' usually, but this is not guaranteed.
    if (process.platform === "win32") {
        let PATH = "Path";
        Object.keys(process.env).forEach(function (e) {
            if (e.match(/^PATH$/i)) {
                PATH = e;
            }
        });
        return PATH;
    }
    return "PATH";
}
async function realPathWithExtension(command) {
    const pathExt = (process.env.pathext || ".EXE").split(";");
    for (const each of pathExt) {
        const filename = `${command}${each}`;
        if (await (0, async_io_1.isFile)(filename)) {
            return filename;
        }
    }
    return undefined;
}
async function getFullPath(command, searchPath) {
    command = command.replace(/"/g, "");
    const ext = (0, path_1.extname)(command);
    if ((0, path_1.isAbsolute)(command)) {
        // if the file has an extension, or we're not on win32, and this is an actual file, use it.
        if (ext || process.platform !== "win32") {
            if (await (0, async_io_1.isFile)(command)) {
                return command;
            }
        }
        // if we're on windows, look for a file with an acceptable extension.
        if (process.platform === "win32") {
            // try all the PATHEXT extensions to see if it is a recognized program
            const cmd = await realPathWithExtension(command);
            if (cmd) {
                return cmd;
            }
        }
        return undefined;
    }
    if (searchPath) {
        const folders = searchPath.split(path_1.delimiter);
        for (const each of folders) {
            const fullPath = await getFullPath((0, path_1.resolve)(each, command));
            if (fullPath) {
                return fullPath;
            }
        }
    }
    return undefined;
}
/**
 * Resolve given package metadata.
 * @param spec This can be a package name with version, the url to a tgz or a local folder.
 * @returns Package metadata.
 */
async function fetchPackageMetadata(spec) {
    try {
        return await pacote.manifest(spec, {
            cache: `${(0, os_1.tmpdir)()}/cache`,
            registry: process.env.autorest_registry || "https://registry.npmjs.org",
            "full-metadata": true,
        });
    }
    catch (error) {
        logger_1.logger.error(`Error resolving package ${spec}`, error);
        throw new exceptions_1.UnresolvedPackageException(spec);
    }
}
exports.fetchPackageMetadata = fetchPackageMetadata;
function resolveName(name, version) {
    try {
        return (0, npm_package_arg_1.resolve)(name, version);
    }
    catch (e) {
        if (e instanceof Error) {
            throw new exceptions_1.InvalidPackageIdentityException(name, version, e.message);
        }
        else {
            throw e;
        }
    }
}
class ExtensionManager {
    constructor(installationPath, sharedLock, disposeLock, packageManager) {
        this.installationPath = installationPath;
        this.sharedLock = sharedLock;
        this.disposeLock = disposeLock;
        this.packageManager = packageManager;
        this.dotnetPath = (0, path_1.normalize)(`${(0, os_1.homedir)()}/.dotnet`);
    }
    static async Create(installationPath, packageManagerType = "yarn", packageManagerPath = undefined) {
        if (!(await (0, async_io_1.exists)(installationPath))) {
            await (0, async_io_1.mkdir)(installationPath);
        }
        if (!(await (0, async_io_1.isDirectory)(installationPath))) {
            throw new tasks_1.Exception(`Extension folder '${installationPath}' is not a valid directory`);
        }
        const lock = new tasks_1.SharedLock(installationPath);
        const packageManager = packageManagerType === "yarn" ? new yarn_1.Yarn(packageManagerPath) : new npm_1.Npm();
        return new ExtensionManager(installationPath, lock, await lock.acquire(), packageManager);
    }
    async dispose() {
        await this.disposeLock();
        this.disposeLock = async () => { };
        this.sharedLock = null;
    }
    async reset() {
        if (!this.sharedLock) {
            throw new tasks_1.Exception("Extension manager has been disposed.");
        }
        // get the exclusive lock
        const release = await this.sharedLock.exclusive();
        try {
            // nuke the folder
            await (0, async_io_1.rmdir)(this.installationPath);
            // recreate the folder
            await (0, async_io_1.mkdir)(this.installationPath);
            await this.packageManager.clean(this.installationPath);
        }
        catch (e) {
            throw new exceptions_1.ExtensionFolderLocked(this.installationPath);
        }
        finally {
            // drop the lock
            await release();
        }
    }
    async getPackageVersions(name) {
        const versions = await this.packageManager.getPackageVersions(process.cwd(), name);
        return versions.sort((b, a) => semver.compare(a, b));
    }
    async findPackage(name, version = "latest") {
        if (version.endsWith(".tgz")) {
            // get the package metadata
            const pm = await fetchPackageMetadata(version);
            return new extension_1.Package(pm, pm, this);
        }
        try {
            // version can be a version or any one of the formats that
            // npm accepts (path, targz, git repo)
            const resolved = resolveName(name, version);
            let resolvedName = resolved.raw;
            // get all matching package versions for that
            if (version.startsWith("~") || version.startsWith("^")) {
                const vers = (await this.getPackageVersions(resolved.raw)).filter((each) => semver.satisfies(each, version));
                if (vers.length > 0) {
                    resolvedName = `${resolved.name}@${vers[0]}`;
                }
            }
            // get the package metadata
            const pm = await fetchPackageMetadata(resolvedName);
            return new extension_1.Package(resolved, pm, this);
        }
        catch (E) {
            // in the event that there isn't a matching package by that name
            // we can try a fallback to see if a gh release has a package
            // (if it is an autorest.<whatever> project)
            // https://github.com/Azure/${PROJECT}/releases/download/v${VERSION}/autorest/${PROJECT}-${VERSION}.tgz
            if (name.startsWith("@autorest/")) {
                const githubRepo = name.replace("@autorest/", "autorest.");
                const githubPkgName = name.replace("@", "").replace("autorest/", "autorest-");
                const githubVersion = version
                    .replace(/^[~|^]/g, "") // Use the exact version instead of range
                    .replace(/_/g, "-"); // Replace _ with - ;
                const ghurl = `https://github.com/Azure/${githubRepo}/releases/download/v${githubVersion}/${githubPkgName}-${githubVersion}.tgz`;
                try {
                    const pm = await fetchPackageMetadata(ghurl);
                    if (pm) {
                        return new extension_1.Package(pm, pm, this);
                    }
                }
                catch (_a) {
                    // no worries, return the previous error
                }
            }
            throw E;
        }
    }
    async getInstalledExtension(name, version) {
        if (!semver.validRange(version)) {
            // if they asked for something that isn't a valid range, we have to find out what version
            // the target package actually is.
            const pkg = await this.findPackage(name, version);
            version = pkg.version;
        }
        const installed = await this.getInstalledExtensions();
        for (const each of installed) {
            if (name === each.name && semver.satisfies(each.version, version)) {
                return each;
            }
        }
        return null;
    }
    async getInstalledExtensions() {
        const results = new Array();
        // iterate thru the folders.
        // the folder name should have the pattern @ORG#NAME@VER or NAME@VER
        for (const folder of await (0, async_io_1.readdir)(this.installationPath)) {
            const fullpath = (0, path_1.join)(this.installationPath, folder);
            if (await (0, async_io_1.isDirectory)(fullpath)) {
                const split = /((@.+)_)?(.+)@(.+)/.exec(folder);
                if (split) {
                    try {
                        const org = split[2];
                        const name = split[3];
                        const version = split[4];
                        const actualPath = org
                            ? (0, path_1.normalize)(`${fullpath}/node_modules/${org}/${name}`)
                            : (0, path_1.normalize)(`${fullpath}/node_modules/${name}`);
                        const pm = await fetchPackageMetadata(actualPath);
                        const ext = new extension_1.Extension(new extension_1.Package(null, pm, this), this.installationPath);
                        if (fullpath !== ext.location) {
                            // eslint-disable-next-line no-console
                            console.trace(`WARNING: Not reporting '${fullpath}' since its package.json claims it should be at '${ext.location}' (probably symlinked once and modified later)`);
                            continue;
                        }
                        results.push(ext);
                    }
                    catch (e) {
                        // ignore things that don't look right.
                    }
                }
            }
        }
        // each folder will contain a node_modules folder, which should have a folder by
        // in the node_modules folder there should be a folder by the name of the
        return results;
    }
    async installPackage(pkg, force, maxWait = 5 * 60 * 1000, reportProgress = () => { }) {
        if (!this.sharedLock) {
            throw new tasks_1.Exception("Extension manager has been disposed.");
        }
        // will throw if the CriticalSection lock can't be acquired.
        // we need this so that only one extension at a time can start installing
        // in this process (since to use NPM right, we have to do a change dir before runinng it)
        // if we ran NPM out-of-proc, this probably wouldn't be necessary.
        const extensionRelease = await ExtensionManager.criticalSection.acquire(maxWait);
        if (!(await (0, async_io_1.exists)(this.installationPath))) {
            await (0, async_io_1.mkdir)(this.installationPath);
        }
        const extension = new extension_1.Extension(pkg, this.installationPath);
        const release = await new tasks_1.Mutex(extension.location).acquire(maxWait / 2);
        try {
            // change directory
            process.chdir(this.installationPath);
            if (await (0, async_io_1.isDirectory)(extension.location)) {
                if (!force) {
                    // already installed
                    // if the target folder is created, we're going to make the naive assumption that the package is installed. (--force will blow away)
                    return extension;
                }
                // force removal first
                try {
                    // progress.NotifyMessage(`Removing existing extension ${extension.location}`);
                    await (0, tasks_1.Delay)(100);
                    await (0, async_io_1.rmdir)(extension.location);
                }
                catch (e) {
                    // no worries.
                }
            }
            // create the folder
            await (0, async_io_1.mkdir)(extension.location);
            const promise = this.packageManager.install(extension.location, [pkg.packageMetadata._resolved], { force }, (progress) => {
                reportProgress({ pkg, ...progress });
            });
            await extensionRelease();
            const result = await promise;
            if (result.success) {
                return extension;
            }
            else {
                const message = [result.error.message, "", "Installation logs: ", formatLogEntries(result.error.logs)];
                throw new exceptions_1.PackageInstallationException(pkg.name, pkg.version, message.join("\n"));
            }
        }
        catch (e) {
            // clean up the attempted install directory
            if (await (0, async_io_1.isDirectory)(extension.location)) {
                await (0, tasks_1.Delay)(100);
                await (0, async_io_1.rmdir)(extension.location);
            }
            if (e instanceof tasks_1.Exception) {
                throw e;
            }
            if (e instanceof exceptions_1.PackageInstallationException) {
                throw e;
            }
            if (e instanceof Error) {
                throw new exceptions_1.PackageInstallationException(pkg.name, pkg.version, e.message + e.stack);
            }
            throw new exceptions_1.PackageInstallationException(pkg.name, pkg.version, `${e}`);
        }
        finally {
            await Promise.all([extensionRelease(), release()]);
        }
    }
    async removeExtension(extension) {
        if (await (0, async_io_1.isDirectory)(extension.location)) {
            const release = await new tasks_1.Mutex(extension.location).acquire();
            await (0, async_io_1.rmdir)(extension.location);
            await release();
        }
    }
    async start(extension, enableDebugger = false) {
        const PathVar = getPathVariableName();
        await this.validateExtensionSystemRequirements(extension);
        if (!extension.definition.scripts) {
            throw new exceptions_1.MissingStartCommandException(extension);
        }
        const script = enableDebugger && extension.definition.scripts.debug
            ? extension.definition.scripts.debug
            : extension.definition.scripts.start;
        // look at the extension for the
        if (!script) {
            throw new exceptions_1.MissingStartCommandException(extension);
        }
        const command = cmdlineToArray(script);
        if (command.length === 0) {
            throw new exceptions_1.MissingStartCommandException(extension);
        }
        // add each engine into the front of the path.
        const env = (0, tasks_1.shallowCopy)(process.env);
        // add potential .bin folders (depends on platform and npm version)
        env[PathVar] = `${(0, path_1.join)(extension.modulePath, "node_modules", ".bin")}${path_1.delimiter}${env[PathVar]}`;
        env[PathVar] = `${(0, path_1.join)(extension.location, "node_modules", ".bin")}${path_1.delimiter}${env[PathVar]}`;
        // find appropriate path for interpreter
        switch (command[0].toLowerCase()) {
            case "node":
            case "node.exe":
                command[0] = nodePath;
                break;
            case "python":
            case "python.exe":
            case "python3":
            case "python3.exe":
                await (0, system_requirements_1.patchPythonPath)(command, { version: ">=3.6" });
                break;
        }
        // ensure parameters requiring quotes have them.
        for (let i = 0; i < command.length; i++) {
            command[i] = quoteIfNecessary(command[i]);
        }
        // spawn the command via the shell (since that how npm would have done it anyway.)
        const fullCommandPath = await getFullPath(command[0], env[getPathVariableName()]);
        if (!fullCommandPath) {
            throw new tasks_1.Exception(`Unable to resolve full path for executable '${command[0]}' -- (cmdline '${command.join(" ")}')`);
        }
        // == special case ==
        // on Windows, if this command has a space in the name, and it's not an .EXE
        // then we're going to have to add the folder to the PATH
        // and execute it by just the filename
        // and set the path back when we're done.
        if (process.platform === "win32" && fullCommandPath.indexOf(" ") > -1 && !/.exe$/gi.exec(fullCommandPath)) {
            // preserve the current path
            const originalPath = process.env[PathVar];
            try {
                // insert the dir into the path
                process.env[PathVar] = `${(0, path_1.dirname)(fullCommandPath)}${path_1.delimiter}${env[PathVar]}`;
                // call spawn and return
                return (0, child_process_1.spawn)((0, path_1.basename)(fullCommandPath), command.slice(1), {
                    env,
                    cwd: extension.modulePath,
                    stdio: ["pipe", "pipe", "pipe"],
                });
            }
            finally {
                // regardless, restore the original path on the way out!
                process.env[PathVar] = originalPath;
            }
        }
        return (0, child_process_1.spawn)(fullCommandPath, command.slice(1), {
            env,
            cwd: extension.modulePath,
            stdio: ["pipe", "pipe", "pipe"],
        });
    }
    /**
     * Validate if present the extension system requirements.
     * @param extension Extension to validate.
     */
    async validateExtensionSystemRequirements(extension) {
        const systemRequirements = extension.definition.systemRequirements;
        if (!systemRequirements) {
            return;
        }
        const errors = await (0, system_requirements_1.validateExtensionSystemRequirements)(systemRequirements);
        if (errors.length > 0) {
            throw new exceptions_1.UnsatisfiedSystemRequirementException(extension, errors);
        }
    }
}
exports.ExtensionManager = ExtensionManager;
ExtensionManager.criticalSection = new tasks_1.CriticalSection();
function formatLogEntries(entries) {
    const lines = ["```", ...entries.map(formatLogEntry), "```"];
    return lines.join("\n");
}
function formatLogEntry(entry) {
    const [first, ...lines] = entry.message.split("\n");
    const spacing = " ".repeat(entry.severity.length);
    return [`${entry.severity}: ${first}`, ...lines.map((x) => `${spacing}  ${x}`)].join("\n");
}
//# sourceMappingURL=main.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/npm.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.Npm = exports.execNpm = exports.DEFAULT_NPM_REGISTRY = void 0;
const path_1 = __webpack_require__("path");
const exec_cmd_1 = __webpack_require__("../../libs/extension/dist/src/exec-cmd.js");
const package_manager_1 = __webpack_require__("../../libs/extension/dist/src/package-manager.js");
exports.DEFAULT_NPM_REGISTRY = "https://registry.npmjs.org";
const getPathToNpmCli = () => {
    const npmPath = (0, path_1.dirname)(/*require.resolve*/("../../../common/temp/node_modules/.pnpm/npm@6.14.9/node_modules/npm/package.json"));
    return (0, path_1.resolve)(`${npmPath}/bin/npm-cli.js`);
};
const execNpm = async (cwd, ...args) => {
    const procArgs = [
        getPathToNpmCli(),
        "--no-shrinkwrap",
        "--registry",
        process.env.autorest_registry || exports.DEFAULT_NPM_REGISTRY,
        ...args,
    ];
    return await (0, exec_cmd_1.execute)(process.execPath, procArgs, { cwd });
};
exports.execNpm = execNpm;
class Npm {
    async install(directory, packages, options) {
        await (0, package_manager_1.ensurePackageJsonExists)(directory);
        const output = await (0, exports.execNpm)(directory, "install", "--save", "--prefix", directory.replace(/\\/g, "/"), ...((options === null || options === void 0 ? void 0 : options.force) ? ["--force"] : []), ...packages);
        if (output.error) {
            return {
                success: false,
                error: {
                    message: `Failed to install package '${packages}' -- ${output.error}`,
                    logs: output.log.split("\n").map((x) => ({ severity: "info", message: x })),
                },
            };
        }
        return { success: true };
    }
    async clean(directory) {
        await (0, exports.execNpm)(directory, "cache", "clean", "--force");
    }
    async getPackageVersions(directory, packageName) {
        const result = await (0, exports.execNpm)(directory, "view", packageName, "versions", "--json");
        return JSON.parse(result.stdout).data;
    }
}
exports.Npm = Npm;
//# sourceMappingURL=npm.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/package-manager.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.ensurePackageJsonExists = void 0;
const fs_1 = __webpack_require__("fs");
const path_1 = __webpack_require__("path");
const { writeFile, access } = fs_1.promises;
/**
 * Ensure there is a pacakge.json in the install directory.
 * This is to ensure that yarn add will not look for a parent package.json and install in the parent folder instead.
 * @param directory Directory where the package will be installed.
 */
async function ensurePackageJsonExists(directory) {
    const filename = (0, path_1.join)(directory, "package.json");
    if (await exists(filename)) {
        return;
    }
    await writeFile(filename, "{}");
}
exports.ensurePackageJsonExists = ensurePackageJsonExists;
async function exists(filename) {
    try {
        await access(filename);
        return true;
    }
    catch (_a) {
        return false;
    }
}
//# sourceMappingURL=package-manager.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/common.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.defineKnownRequirement = exports.getExecutablePath = void 0;
const version_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/version.js");
/**
 * Returns the path to the executable as asked in the requirement.
 * @param requirement System requirement definition.
 * @returns If the requirement provide an environment variable for the path returns the value of that environment variable. undefined otherwise.
 */
const getExecutablePath = (requirement) => requirement.environmentVariable && process.env[requirement.environmentVariable];
exports.getExecutablePath = getExecutablePath;
/**
 *
 * @param name Name of the command.
 * @param getVersion Function used to get the version. Callbacks takes the resolved command from the requirement environmentVariable is provided or default the the value of @name
 */
const defineKnownRequirement = (name, getVersion) => {
    return async (requirement) => {
        const executablePath = (0, exports.getExecutablePath)(requirement);
        const command = executablePath !== null && executablePath !== void 0 ? executablePath : name;
        const actualVersion = await getVersion(command);
        if (actualVersion === undefined) {
            return {
                error: true,
                name,
                command,
                message: `'${name}' command line is not found in the path. Make sure to have ${name} installed.`,
            };
        }
        return (0, version_1.validateVersionRequirement)({ name, command }, actualVersion, requirement);
    };
};
exports.defineKnownRequirement = defineKnownRequirement;
//# sourceMappingURL=common.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/dotnet.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.resolveDotnetRequirement = exports.DotnetExeName = void 0;
const exec_cmd_1 = __webpack_require__("../../libs/extension/dist/src/exec-cmd.js");
const common_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/common.js");
exports.DotnetExeName = "dotnet";
exports.resolveDotnetRequirement = (0, common_1.defineKnownRequirement)(exports.DotnetExeName, async (cmd) => {
    try {
        const result = await (0, exec_cmd_1.execute)(cmd, ["--version"]);
        return result.stdout;
    }
    catch (e) {
        return undefined;
    }
});
//# sourceMappingURL=dotnet.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/generic.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.resolveGenericSystemRequirement = void 0;
const command_exists_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/command-exists@1.2.9/node_modules/command-exists/index.js"));
const resolveGenericSystemRequirement = async (name) => {
    const isAvailable = await checkIfExcutableAvailable(name);
    const resolution = { name, command: name };
    return isAvailable
        ? resolution
        : {
            error: true,
            ...resolution,
            message: `Couldn't find executable '${name}' in path. Make sure it is installed.`,
        };
};
exports.resolveGenericSystemRequirement = resolveGenericSystemRequirement;
const checkIfExcutableAvailable = async (name) => {
    try {
        await (0, command_exists_1.default)(name);
        return true;
    }
    catch (_a) {
        return false;
    }
};
//# sourceMappingURL=generic.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/extension/dist/src/system-requirements/system-requirements.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/system-requirements/models.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/system-requirements/python.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/system-requirements/java.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/system-requirements/dotnet.js"), exports);
__exportStar(__webpack_require__("../../libs/extension/dist/src/system-requirements/generic.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/java.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.resolveJavaRequirement = exports.JavaExeName = void 0;
const exec_cmd_1 = __webpack_require__("../../libs/extension/dist/src/exec-cmd.js");
const common_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/common.js");
exports.JavaExeName = "java";
exports.resolveJavaRequirement = (0, common_1.defineKnownRequirement)(exports.JavaExeName, async () => {
    try {
        const result = await (0, exec_cmd_1.execute)(exports.JavaExeName, ["-version"]);
        return parseJavaVersionFromStdout(result.stdout);
    }
    catch (e) {
        return undefined;
    }
});
const JAVA_VERSION_REGEX = /java version "(.*)"/;
const parseJavaVersionFromStdout = (stdout) => {
    const match = JAVA_VERSION_REGEX.exec(stdout);
    return match === null || match === void 0 ? void 0 : match[1];
};
//# sourceMappingURL=java.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/models.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
//# sourceMappingURL=models.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/python.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.patchPythonPath = exports.updatePythonPath = exports.resolvePythonRequirement = exports.PythonRequirement = void 0;
const exec_cmd_1 = __webpack_require__("../../libs/extension/dist/src/exec-cmd.js");
const common_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/common.js");
const version_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/version.js");
exports.PythonRequirement = "python";
/**
 * Small python script that will print the python version.
 */
const PRINT_PYTHON_VERSION_SCRIPT = "import sys; print('.'.join(map(str, sys.version_info[:3])))";
const resolvePythonRequirement = async (requirement) => {
    var _a;
    // Hardcoding AUTOREST_PYTHON_EXE is for backward compatibility
    const path = (_a = (0, common_1.getExecutablePath)(requirement)) !== null && _a !== void 0 ? _a : process.env["AUTOREST_PYTHON_EXE"];
    if (path) {
        return await tryPython(requirement, path);
    }
    const errors = [];
    // On windows try `py` executable with `-3` flag.
    if (process.platform === "win32") {
        const pyResult = await tryPython(requirement, "py", ["-3"]);
        if ("error" in pyResult) {
            errors.push(pyResult);
        }
        else {
            return pyResult;
        }
    }
    const python3Result = await tryPython(requirement, "python3");
    if ("error" in python3Result) {
        errors.push(python3Result);
    }
    else {
        return python3Result;
    }
    const pythonResult = await tryPython(requirement, "python");
    if ("error" in pythonResult) {
        errors.push(pythonResult);
    }
    else {
        return pythonResult;
    }
    return createPythonErrorMessage(requirement, errors);
};
exports.resolvePythonRequirement = resolvePythonRequirement;
/**
 * This method is kept for backward compatibility and will be removed in a future release.
 * @deprecated Please use patchPythonPath(command, requirement) instead.
 */
const updatePythonPath = async (command) => {
    const newCommand = await (0, exports.patchPythonPath)(command, { version: ">=3.6", environmentVariable: "AUTOREST_PYTHON_EXE" });
    command[0] = newCommand[0];
    return newCommand;
};
exports.updatePythonPath = updatePythonPath;
/**
 * @param command list of the command and arguments. First item in array must be a python exe @see KnownPythonExe. (e.g. ["python", "mypythonfile.py"]
 * @param requirement
 */
const patchPythonPath = async (command, requirement) => {
    var _a;
    const [_, ...args] = command;
    const resolution = await (0, exports.resolvePythonRequirement)(requirement);
    if ("error" in resolution) {
        throw new Error(`Failed to find compatible python version. ${resolution.message}`);
    }
    return [resolution.command, ...((_a = resolution.additionalArgs) !== null && _a !== void 0 ? _a : []), ...args];
};
exports.patchPythonPath = patchPythonPath;
const tryPython = async (requirement, command, additionalArgs = []) => {
    const resolution = {
        name: exports.PythonRequirement,
        command,
        additionalArgs: additionalArgs.length > 0 ? additionalArgs : undefined,
    };
    try {
        const result = await (0, exec_cmd_1.execute)(command, [...additionalArgs, "-c", PRINT_PYTHON_VERSION_SCRIPT]);
        return (0, version_1.validateVersionRequirement)(resolution, result.stdout.trim(), requirement);
    }
    catch (e) {
        return {
            error: true,
            ...resolution,
            message: `'${command}' command line is not found in the path. Make sure to have it installed.`,
        };
    }
};
const createPythonErrorMessage = (requirement, errors) => {
    var _a;
    const versionReq = (_a = requirement.version) !== null && _a !== void 0 ? _a : "*";
    const lines = [
        `Couldn't find a valid python interpreter satisfying the requirement (version: ${versionReq}). Tried:`,
        ...errors.map((x) => ` - ${x.command} (${x.message})`),
    ];
    return {
        error: true,
        name: "python",
        command: "python",
        message: lines.join("\n"),
    };
};
//# sourceMappingURL=python.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/system-requirements.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.resolveSystemRequirement = exports.resolveSystemRequirements = exports.validateExtensionSystemRequirements = void 0;
const dotnet_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/dotnet.js");
const generic_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/generic.js");
const java_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/java.js");
const python_1 = __webpack_require__("../../libs/extension/dist/src/system-requirements/python.js");
/**
 * Resolve the extension requirements and returns a list of errors.
 * @param requirements Map of requirements.
 */
const validateExtensionSystemRequirements = async (requirements) => {
    const errors = [];
    const results = await (0, exports.resolveSystemRequirements)(requirements);
    for (const [name, requirement] of Object.entries(requirements)) {
        const result = results[name];
        if ("error" in result) {
            const message = requirement.message ? `${requirement.message}. ${result.message}` : result.message;
            errors.push({ ...result, message });
        }
    }
    return errors;
};
exports.validateExtensionSystemRequirements = validateExtensionSystemRequirements;
/**
 * Validate the given commands are available in the path and check the version for known commands.
 * @param name Name of the command.
 * @param requirement Requirement configuration.
 * @returns map of resolution or error with the key being the command names provided.
 */
const resolveSystemRequirements = async (requirements) => {
    const results = {};
    for (const [name, requirement] of Object.entries(requirements)) {
        results[name] = await (0, exports.resolveSystemRequirement)(name, requirement);
    }
    return results;
};
exports.resolveSystemRequirements = resolveSystemRequirements;
/**
 * Validate the given command is available in the path and check the version for known commands.
 * @param name Name of the command.
 * @param requirement Requirement configuration.
 * @returns resolution or error.
 */
const resolveSystemRequirement = async (name, requirement) => {
    switch (name) {
        case dotnet_1.DotnetExeName:
            return (0, dotnet_1.resolveDotnetRequirement)(requirement);
        case java_1.JavaExeName:
            return (0, java_1.resolveJavaRequirement)(requirement);
        case python_1.PythonRequirement:
            return (0, python_1.resolvePythonRequirement)(requirement);
        default:
            return (0, generic_1.resolveGenericSystemRequirement)(name);
    }
};
exports.resolveSystemRequirement = resolveSystemRequirement;
//# sourceMappingURL=system-requirements.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/system-requirements/version.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.versionIsSatisfied = exports.validateVersionRequirement = void 0;
const semver_1 = __importDefault(__webpack_require__("../../../common/temp/node_modules/.pnpm/semver@5.7.1/node_modules/semver/semver.js"));
/**
 * Validate the provided system requirement resolution is satisfying the version requirement if applicable.
 * @param resolution Command resolution.
 * @param actualVersion Version for that resolution.
 * @param requirement Requirement.
 * @returns the resolution if it is valid or an @see SystemRequirementError if not.
 */
const validateVersionRequirement = (resolution, actualVersion, requirement) => {
    if (!requirement.version) {
        return resolution; // No version requirement.
    }
    try {
        if ((0, exports.versionIsSatisfied)(actualVersion, requirement.version)) {
            return resolution;
        }
        return {
            ...resolution,
            error: true,
            message: `'${resolution.command}' version is '${actualVersion}' but doesn't satisfy requirement '${requirement.version}'. Please update.`,
            actualVersion: actualVersion,
            neededVersion: requirement.version,
        };
    }
    catch (_a) {
        return {
            ...resolution,
            error: true,
            message: `Couldn't parse the version ${actualVersion}. This is not a valid semver version.`,
            actualVersion: actualVersion,
            neededVersion: requirement.version,
        };
    }
};
exports.validateVersionRequirement = validateVersionRequirement;
const versionIsSatisfied = (version, requirement) => {
    const cleanedVersion = semver_1.default.coerce(version);
    if (!cleanedVersion) {
        throw new Error(`Invalid version ${version}.`);
    }
    return semver_1.default.satisfies(cleanedVersion, requirement, true);
};
exports.versionIsSatisfied = versionIsSatisfied;
//# sourceMappingURL=version.js.map

/***/ }),

/***/ "../../libs/extension/dist/src/yarn.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.Yarn = void 0;
const fs_1 = __webpack_require__("fs");
const os_1 = __webpack_require__("os");
const path_1 = __webpack_require__("path");
const async_io_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/@azure-tools/async-io@3.0.254/node_modules/@azure-tools/async-io/dist/main.js");
const exec_cmd_1 = __webpack_require__("../../libs/extension/dist/src/exec-cmd.js");
const npm_1 = __webpack_require__("../../libs/extension/dist/src/npm.js");
const package_manager_1 = __webpack_require__("../../libs/extension/dist/src/package-manager.js");
let _cli;
const getPathToYarnCli = async () => {
    const nodeModulesYarn = (0, path_1.resolve)(`${__dirname}/../node_modules/yarn/lib/cli.js`);
    if (await (0, async_io_1.isFile)(nodeModulesYarn)) {
        _cli = nodeModulesYarn;
        return _cli;
    }
    const fname = (0, path_1.resolve)(`${__dirname}/../yarn/cli.js`);
    if (await (0, async_io_1.isFile)(fname)) {
        _cli = fname;
    }
    else {
        // otherwise, we might be in a 'static-linked' library and
        // we should try to load it and put a copy in $tmp somewhere.
        _cli = (0, path_1.join)((0, os_1.tmpdir)(), "yarn-cli.js");
        // did we copy it already?
        if (await (0, async_io_1.isFile)(_cli)) {
            return _cli;
        }
        // no, let's copy it now.
        await (0, async_io_1.writeFile)(_cli, (0, fs_1.readFileSync)(fname));
    }
    return _cli;
};
class Yarn {
    constructor(pathToYarnCli = undefined) {
        this.pathToYarnCli = pathToYarnCli;
    }
    async install(directory, packages, options, reportProgress) {
        await (0, package_manager_1.ensurePackageJsonExists)(directory);
        let total = 1;
        const logs = [];
        const handleYarnEvent = (event) => {
            switch (event.type) {
                case "progressStart":
                    if (event.data.total !== 0) {
                        reportProgress === null || reportProgress === void 0 ? void 0 : reportProgress({ current: 0, total, id: event.data.id });
                        total = event.data.total;
                    }
                    break;
                case "progressFinish":
                    reportProgress === null || reportProgress === void 0 ? void 0 : reportProgress({ current: 100, total, id: event.data.id });
                    break;
                case "progressTick":
                    reportProgress === null || reportProgress === void 0 ? void 0 : reportProgress({ current: Math.min(event.data.current, total), total, id: event.data.id });
                    break;
                case "error":
                case "info":
                case "warning":
                    logs.push({ severity: event.type, message: event.data });
                    break;
                case "step":
                    logs.push({ severity: "info", message: ` Step: ${event.data.message}` });
                    break;
            }
        };
        const output = await this.execYarn(directory, ["add", "--global-folder", directory.replace(/\\/g, "/"), ...((options === null || options === void 0 ? void 0 : options.force) ? ["--force"] : []), ...packages], handleYarnEvent);
        if (output.error) {
            return {
                success: false,
                error: {
                    message: `Failed to install package '${packages}' -- ${output.error}`,
                    logs,
                },
            };
        }
        else {
            return { success: true };
        }
    }
    async clean(directory) {
        await this.execYarn(directory, ["cache", "clean", "--force"]);
    }
    async getPackageVersions(directory, packageName) {
        const result = await this.execYarn(directory, ["info", packageName, "versions", "--json"]);
        return JSON.parse(result.stdout).data;
    }
    async execYarn(cwd, args, onYarnEvent) {
        var _a;
        const procArgs = [
            (_a = this.pathToYarnCli) !== null && _a !== void 0 ? _a : (await getPathToYarnCli()),
            "--no-node-version-check",
            "--no-lockfile",
            "--json",
            "--registry",
            process.env.autorest_registry || npm_1.DEFAULT_NPM_REGISTRY,
            ...args,
        ];
        const newEnv = {
            ...process.env,
            YARN_IGNORE_PATH: "1", // Prevent yarn from using a different version if configured in ~/.yarnrc
        };
        const handleYarnLog = (buffer) => {
            const str = buffer.toString();
            for (const line of str.split(/\r?\n/).filter((x) => x !== "")) {
                try {
                    const data = JSON.parse(line);
                    onYarnEvent === null || onYarnEvent === void 0 ? void 0 : onYarnEvent(data);
                }
                catch (e) {
                    // NOOP
                }
            }
        };
        return await (0, exec_cmd_1.execute)(process.execPath, procArgs, {
            cwd,
            env: newEnv,
            onStdOutData: handleYarnLog,
            onStdErrData: handleYarnLog,
        });
    }
}
exports.Yarn = Yarn;
//# sourceMappingURL=yarn.js.map

/***/ }),

/***/ "../../libs/json/dist/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/json/dist/json-pointer/json-pointer.js"), exports);
__exportStar(__webpack_require__("../../libs/json/dist/traverse/traverse.js"), exports);
__exportStar(__webpack_require__("../../libs/json/dist/utils/utils.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/json/dist/json-pointer/json-pointer.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.appendJsonPointer = exports.getFromJsonPointer = exports.serializeJsonPointer = exports.parseJsonPointer = void 0;
/**
 * Escapes a reference token
 *
 * @param str
 * @returns {string}
 */
function escape(str) {
    return typeof str === "string" ? str.toString().replace(/~/g, "~0").replace(/\//g, "~1") : str;
}
/**
 * Unescapes a reference token
 *
 * @param str
 * @returns {string}
 */
function unescape(str) {
    return str.replace(/~1/g, "/").replace(/~0/g, "~");
}
/**
 * Converts a json pointer into a array of reference tokens
 *
 * @param pointer
 * @returns {Array}
 */
function parseJsonPointer(pointer) {
    if (pointer === "") {
        return new Array();
    }
    if (pointer.charAt(0) !== "/") {
        throw new Error("Invalid JSON pointer: " + pointer);
    }
    return pointer.substring(1).split(/\//).map(unescape);
}
exports.parseJsonPointer = parseJsonPointer;
/**
 * Builds a json pointer from a array of reference tokens
 *
 * @param refTokens segment of paths.
 * @returns JsonPointer string.
 */
function serializeJsonPointer(refTokens) {
    if (refTokens.length === 0) {
        return "";
    }
    return `/${refTokens.map(escape).join("/")}`;
}
exports.serializeJsonPointer = serializeJsonPointer;
/**
 * Lookup a json pointer in an object
 *
 * @param {Object} obj - object to work on
 * @param {JsonPointer|JsonPointerTokens} pointer - pointer or tokens to a location
 * @returns {*} - value at location, or will throw if location is not present.
 */
function getFromJsonPointer(obj, pointer) {
    const refTokens = Array.isArray(pointer) ? pointer : parseJsonPointer(pointer);
    for (let i = 0; i < refTokens.length; ++i) {
        const tok = refTokens[i];
        if (!(typeof obj === "object" && tok in obj)) {
            throw new Error("Invalid reference token: " + tok);
        }
        obj = obj[tok];
    }
    return obj;
}
exports.getFromJsonPointer = getFromJsonPointer;
/**
 * Add a new segment to a json pointer
 * @param pointer Pointer
 * @param suffix Suffix
 * @returns new json pointer
 */
function appendJsonPointer(pointer, ...suffixes) {
    return serializeJsonPointer(parseJsonPointer(pointer).concat(suffixes));
}
exports.appendJsonPointer = appendJsonPointer;
//# sourceMappingURL=json-pointer.js.map

/***/ }),

/***/ "../../libs/json/dist/traverse/traverse.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.walk = void 0;
/**
 * Recursively visit all the node in a json object.
 * Visitor should return a @see {WalkStatus} to determine if the object should be visited further.
 * @param obj Object to visit
 * @param visitor Vistor function.
 */
function walk(obj, visitor) {
    const visisted = new Set();
    return walkInternal(obj, [], visisted, visitor);
}
exports.walk = walk;
function walkInternal(obj, path, visisted, visitor) {
    if (!obj) {
        return undefined;
    }
    if (visisted.has(obj)) {
        return;
    }
    visisted.add(obj);
    if (visitor(obj, path) !== "visit-children") {
        return;
    }
    if (Array.isArray(obj)) {
        for (const [index, item] of obj.entries()) {
            walkInternal(item, [...path, index.toString()], visisted, visitor);
        }
    }
    else if (typeof obj === "object") {
        // eslint-disable-next-line @typescript-eslint/no-non-null-assertion
        for (const [key, item] of Object.entries(obj)) {
            walkInternal(item, [...path, key], visisted, visitor);
        }
    }
    return false;
}
//# sourceMappingURL=traverse.js.map

/***/ }),

/***/ "../../libs/json/dist/utils/utils.js":
/***/ ((__unused_webpack_module, exports) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.validateJson = void 0;
/**
 * Validate content is json.
 * @param json Json string to validate
 * @returns Error or undefined
 */
function validateJson(json) {
    try {
        // quick check on data.
        JSON.parse(json);
    }
    catch (e) {
        if (e instanceof SyntaxError) {
            const message = "" + e.message;
            try {
                return {
                    message: message.substring(0, message.lastIndexOf("at")).trim(),
                    position: parseInt(e.message.substring(e.message.lastIndexOf(" ")).trim()),
                };
            }
            catch (_a) {
                // ignore.
            }
        }
    }
    return undefined;
}
exports.validateJson = validateJson;
//# sourceMappingURL=utils.js.map

/***/ }),

/***/ "../../libs/yaml/dist/index.js":
/***/ (function(__unused_webpack_module, exports, __webpack_require__) {

"use strict";

var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __exportStar = (this && this.__exportStar) || function(m, exports) {
    for (var p in m) if (p !== "default" && !Object.prototype.hasOwnProperty.call(exports, p)) __createBinding(exports, m, p);
};
Object.defineProperty(exports, "__esModule", ({ value: true }));
__exportStar(__webpack_require__("../../libs/yaml/dist/parser.js"), exports);
__exportStar(__webpack_require__("../../libs/yaml/dist/types.js"), exports);
__exportStar(__webpack_require__("../../libs/yaml/dist/utils.js"), exports);
//# sourceMappingURL=index.js.map

/***/ }),

/***/ "../../libs/yaml/dist/parser.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.fastStringify = exports.Stringify = exports.parseYAML = exports.valueToAst = exports.deepNormalize = exports.stringifyYamlAst = exports.cloneYamlAst = exports.getYamlNodeValue = exports.parseYAMLAst = exports.parseYAMLFast = void 0;
// TODO: the following is only required because safeDump of "yaml-ast-parser" has this bug: https://github.com/mulesoft-labs/yaml-ast-parser/issues/30
// PLEASE: remove the entire dependency to js-yaml once that is fixed!
const js_yaml_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/js-yaml@4.0.0/node_modules/js-yaml/index.js");
const lodash_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/lodash@4.17.21/node_modules/lodash/lodash.js");
const yaml_ast_parser_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/yaml-ast-parser@0.0.43/node_modules/yaml-ast-parser/dist/src/index.js");
const types_1 = __webpack_require__("../../libs/yaml/dist/types.js");
/**
 * Parse YAML without creating the AST tree.
 */
exports.parseYAMLFast = js_yaml_1.load;
/**
 * Parse YAML to AST tree.
 */
function parseYAMLAst(rawYaml) {
    return (0, yaml_ast_parser_1.safeLoad)(rawYaml);
}
exports.parseYAMLAst = parseYAMLAst;
function getYamlNodeValue(yamlNode) {
    return computeNodeValue(yamlNode, new WeakMap());
}
exports.getYamlNodeValue = getYamlNodeValue;
function computeNodeValue(yamlNode, cache) {
    if (yamlNode === undefined) {
        return { result: undefined, errors: [] };
    }
    const cachedValue = cache.get(yamlNode);
    if (cachedValue) {
        return { result: cachedValue, errors: [] };
    }
    const errors = yamlNode.errors.filter((x) => !x.isWarning);
    if (errors.length > 0) {
        return {
            result: undefined,
            errors: errors.map((error) => {
                return { message: `Syntax error: ${error.reason}`, position: error.mark.position };
            }),
        };
    }
    switch (yamlNode.kind) {
        case types_1.Kind.SCALAR: {
            return computeScalarNodeValue(yamlNode, cache);
        }
        case types_1.Kind.MAPPING:
            return {
                result: undefined,
                errors: [{ message: "Syntax error: Encountered bare mapping.", position: yamlNode.startPosition }],
            };
        case types_1.Kind.MAP: {
            return computeMapNodeValue(yamlNode, cache);
        }
        case types_1.Kind.SEQ: {
            return computeSequenceNodeValue(yamlNode, cache);
        }
        case types_1.Kind.ANCHOR_REF: {
            return computeNodeValue(yamlNode.value, cache);
        }
        case types_1.Kind.INCLUDE_REF:
            return {
                result: undefined,
                errors: [{ message: "Syntax error: INCLUDE_REF not implemented.", position: yamlNode.startPosition }],
            };
        default:
            throw new Error("Unknown YAML node kind.");
    }
}
function computeScalarNodeValue(yamlNodeScalar, cache) {
    const value = yamlNodeScalar.valueObject !== undefined
        ? yamlNodeScalar.valueObject
        : yamlNodeScalar.singleQuoted
            ? yamlNodeScalar.value
            : (0, js_yaml_1.load)(yamlNodeScalar.rawValue);
    cache.set(yamlNodeScalar, value);
    return { result: value, errors: [] };
}
function computeMapNodeValue(yamlNodeMapping, cache) {
    const result = {};
    cache.set(yamlNodeMapping, result);
    let errors = [];
    for (const mapping of yamlNodeMapping.mappings) {
        if (mapping.key.kind !== types_1.Kind.SCALAR) {
            errors.push({
                message: "Syntax error: Only scalar keys are allowed as mapping keys.",
                position: mapping.key.startPosition,
            });
        }
        else if (mapping.value === null) {
            errors.push({ message: "Syntax error: No mapping value found.", position: mapping.key.endPosition });
        }
        else {
            const parsed = computeNodeValue(mapping.value, cache);
            if (parsed.errors.length === 0) {
                if (mapping.key.value === "<<") {
                    for (const [key, value] of Object.entries(parsed.result)) {
                        result[key] = value;
                    }
                }
                else {
                    result[mapping.key.value] = parsed.result;
                }
            }
            else {
                errors = errors.concat(parsed.errors);
            }
        }
    }
    return { result, errors };
}
function computeSequenceNodeValue(yamlNodeSequence, cache) {
    const result = [];
    cache.set(yamlNodeSequence, result);
    let errors = [];
    for (const item of yamlNodeSequence.items) {
        const itemResult = computeNodeValue(item, cache);
        if (itemResult.errors.length === 0) {
            result.push(itemResult.result);
        }
        else {
            errors = errors.concat(itemResult.errors);
        }
    }
    return { result: result, errors };
}
function cloneYamlAst(ast) {
    if (ast.kind === types_1.Kind.MAPPING) {
        return (0, yaml_ast_parser_1.newMapping)(cloneYamlAst(ast.key), cloneYamlAst(ast.value));
    }
    return parseYAMLAst(stringifyYamlAst(ast));
}
exports.cloneYamlAst = cloneYamlAst;
function stringifyYamlAst(ast) {
    return fastStringify(getYamlNodeValue(ast).result);
}
exports.stringifyYamlAst = stringifyYamlAst;
/**
 * Normalizes the order of given object's keys (sorts recursively)
 */
function deepNormalize(object) {
    const seen = new WeakSet();
    const clone = (0, lodash_1.cloneDeep)(object);
    const norm = (o) => {
        if (Array.isArray(o)) {
            o.forEach(norm);
        }
        else if (o && typeof o == "object") {
            if (seen.has(o)) {
                return;
            }
            seen.add(o);
            const keys = Object.keys(o).sort();
            const oo = { ...o };
            for (const k of keys) {
                delete o[k];
            }
            for (const k of keys) {
                norm((o[k] = oo[k]));
            }
        }
    };
    norm(clone);
    return clone;
}
exports.deepNormalize = deepNormalize;
/**
 * Create an AST tree of a given object.
 */
function valueToAst(object) {
    return parseYAMLAst(fastStringify(object));
}
exports.valueToAst = valueToAst;
function parseYAML(rawYaml) {
    const node = parseYAMLAst(rawYaml);
    return getYamlNodeValue(node);
}
exports.parseYAML = parseYAML;
function Stringify(object) {
    return "---\n" + (0, js_yaml_1.dump)(object, { skipInvalid: true });
}
exports.Stringify = Stringify;
function fastStringify(obj) {
    // has duplicate objects?
    const seen = new WeakSet();
    const losslessJsonSerializable = (o) => {
        if (o && typeof o == "object") {
            if (seen.has(o)) {
                return false;
            }
            seen.add(o);
        }
        if (Array.isArray(o)) {
            return o.every(losslessJsonSerializable);
        }
        else if (o && typeof o == "object") {
            return Object.values(o).every(losslessJsonSerializable);
        }
        return true;
    };
    if (losslessJsonSerializable(obj)) {
        try {
            return JSON.stringify(obj, null, 1);
        }
        catch (_a) {
            // ignore.
        }
    }
    return Stringify(obj);
}
exports.fastStringify = fastStringify;
//# sourceMappingURL=parser.js.map

/***/ }),

/***/ "../../libs/yaml/dist/types.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.Kind = void 0;
var yaml_ast_parser_1 = __webpack_require__("../../../common/temp/node_modules/.pnpm/yaml-ast-parser@0.0.43/node_modules/yaml-ast-parser/dist/src/index.js");
Object.defineProperty(exports, "Kind", ({ enumerable: true, get: function () { return yaml_ast_parser_1.Kind; } }));
//# sourceMappingURL=types.js.map

/***/ }),

/***/ "../../libs/yaml/dist/utils.js":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {

"use strict";

Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.replaceYamlAstNode = exports.getYamlNodeByPath = exports.walkYamlAst = void 0;
const types_1 = __webpack_require__("../../libs/yaml/dist/types.js");
/**
 * Walk the yaml ast tree.
 * @param node Node to start walking.
 * @param walker Callback called for each nodes
 */
function walkYamlAst(node, walker) {
    walkYamlAstInternal(node, [], walker);
}
exports.walkYamlAst = walkYamlAst;
function walkYamlAstInternal(node, currentPath, walker) {
    walker({ path: currentPath, node });
    switch (node.kind) {
        case types_1.Kind.MAPPING:
            walkYamlAstInternal(node.value, currentPath.concat([node.key.value]), walker);
            break;
        case types_1.Kind.MAP:
            for (const mapping of node.mappings) {
                walkYamlAstInternal(mapping, currentPath, walker);
            }
            break;
        case types_1.Kind.SEQ:
            for (let i = 0; i < node.items.length; ++i) {
                walkYamlAstInternal(node.items[i], currentPath.concat([i]), walker);
            }
            break;
    }
}
function getYamlNodeByPath(base, jsonPath) {
    try {
        for (const jsonPathPart of jsonPath) {
            base = getYamlNodeByKey(base, jsonPathPart, true);
        }
        return base;
    }
    catch (error) {
        throw new Error(`Error retrieving '${jsonPath.join(">")}' (${error})`);
    }
}
exports.getYamlNodeByPath = getYamlNodeByPath;
/**
 * Resolves the YAML node given a path PathComponent.
 * @param yamlAstRoot            Root node of AST (required for resolving anchor references)
 * @param base         Current AST node to start resolving from
 * @param jsonPathPart           Path component to resolve
 * @param deferResolvingMappings If set to true, if resolving to a mapping, will return the entire mapping node instead of just the value (useful if desiring keys)
 */
function getYamlNodeByKey(base, jsonPathPart, deferResolvingMappings) {
    switch (base.kind) {
        case types_1.Kind.SCALAR:
            throw new Error(`Trying to retrieve '${jsonPathPart}' from scalar value`);
        case types_1.Kind.MAPPING: {
            if (deferResolvingMappings) {
                return getYamlNodeByKey(base.value, jsonPathPart, deferResolvingMappings);
            }
            if (jsonPathPart.toString() !== base.key.value) {
                throw new Error(`Trying to retrieve '${jsonPathPart}' from mapping with key '${base.key.value}'`);
            }
            return base.value;
        }
        case types_1.Kind.MAP: {
            const mapping = getYamlMapProperty(base, jsonPathPart.toString());
            if (mapping !== undefined) {
                return deferResolvingMappings ? mapping : getYamlNodeByKey(mapping, jsonPathPart, deferResolvingMappings);
            }
            throw new Error(`Trying to retrieve '${jsonPathPart}' from mapping that contains no such key`);
        }
        case types_1.Kind.SEQ: {
            const pathPartNumber = Number(jsonPathPart);
            if (typeof jsonPathPart !== "number" && isNaN(pathPartNumber)) {
                throw new Error(`Trying to retrieve non-string item '${jsonPathPart}' from sequence`);
            }
            if (0 > pathPartNumber || pathPartNumber >= base.items.length) {
                throw new Error(`Trying to retrieve item '${jsonPathPart}' from sequence with '${base.items.length}' items (index out of bounds)`);
            }
            return base.items[pathPartNumber];
        }
        case types_1.Kind.ANCHOR_REF: {
            return getYamlNodeByKey(base.value, jsonPathPart, deferResolvingMappings);
        }
        case types_1.Kind.INCLUDE_REF:
            throw new Error("INCLUDE_REF not implemented");
    }
    throw new Error(`Unexpected YAML AST node kind '${base.kind}'`);
}
function getYamlMapProperty(node, property) {
    return node.mappings.find((x) => x.key.value === property);
}
function replaceYamlAstNode(root, target, value) {
    // root replacement?
    if (target === root) {
        return value;
    }
    const parent = target.kind === types_1.Kind.MAPPING ? target : target.parent;
    switch (parent.kind) {
        case types_1.Kind.MAPPING: {
            const astSub = parent;
            // replace the mapping's value
            if (value !== undefined && value.kind !== types_1.Kind.MAPPING) {
                astSub.value = value;
                return root;
            }
            // replace the mapping
            const parentMap = parent.parent;
            const index = parentMap.mappings.indexOf(astSub);
            if (value !== undefined) {
                parentMap.mappings[index] = value;
            }
            else {
                parentMap.mappings = parentMap.mappings.filter((x, i) => i !== index);
            }
            return root;
        }
        case types_1.Kind.SEQ: {
            const astSub = parent;
            const index = astSub.items.indexOf(target);
            if (value !== undefined) {
                astSub.items[index] = value;
            }
            else {
                astSub.items = astSub.items.filter((x, i) => i !== index);
            }
            return root;
        }
    }
    throw new Error(`unexpected YAML AST node kind '${parent.kind}' for a parent`);
}
exports.replaceYamlAstNode = replaceYamlAstNode;
//# sourceMappingURL=utils.js.map

/***/ })

};
;
//# sourceMappingURL=src_autorest-as-a-service_ts.js.map