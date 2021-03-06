/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	var __webpack_modules__ = ({

/***/ "./src/exports.ts":
/***/ ((__unused_webpack_module, exports, __webpack_require__) => {


/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
/* eslint-disable @typescript-eslint/triple-slash-reference */
/* eslint-disable @typescript-eslint/no-non-null-assertion */
/// <reference path="../definitions/core.d.ts" />
/// <reference path="../definitions/vscode.d.ts" />
Object.defineProperty(exports, "__esModule", ({ value: true }));
exports.toJSON = exports.identifyDocument = exports.isOpenApiDocument = exports.create = exports.initialize = exports.getApplicationEntrypoint = exports.AutoRest = exports.DocumentType = exports.Channel = exports.color = void 0;
// everything else.
const path_1 = __webpack_require__("path");
// exports the public AutoRest definitions
const autorest_as_a_service_1 = __webpack_require__("./src/autorest-as-a-service.ts");
// This is needed currently in autorest-as-service when starting @autorest/core out of proc for @autorest/core version older than 3.6.0
var common_1 = __webpack_require__("../../libs/common/dist/index.js");
Object.defineProperty(exports, "color", ({ enumerable: true, get: function () { return common_1.color; } }));
/**
 * The Channel that a message is registered with.
 */
var Channel;
(function (Channel) {
    /** Information is considered the mildest of responses; not necesarily actionable. */
    Channel[Channel["Information"] = "information"] = "Information";
    /** Warnings are considered important for best practices, but not catastrophic in nature. */
    Channel[Channel["Warning"] = "warning"] = "Warning";
    /** Errors are considered blocking issues that block a successful operation.  */
    Channel[Channel["Error"] = "error"] = "Error";
    /** Debug messages are designed for the developer to communicate internal autorest implementation details. */
    Channel[Channel["Debug"] = "debug"] = "Debug";
    /** Verbose messages give the user additional clarity on the process. */
    Channel[Channel["Verbose"] = "verbose"] = "Verbose";
    /** Catastrophic failure, likely abending the process.  */
    Channel[Channel["Fatal"] = "fatal"] = "Fatal";
    /** Hint messages offer guidance or support without forcing action. */
    Channel[Channel["Hint"] = "hint"] = "Hint";
    /** File represents a file output from an extension. Details are a Artifact and are required.  */
    Channel[Channel["File"] = "file"] = "File";
    /** content represents an update/creation of a configuration file. The final uri will be in the same folder as the primary config file. */
    Channel[Channel["Configuration"] = "configuration"] = "Configuration";
    /** Protect is a path to not remove during a clear-output-folder.  */
    Channel[Channel["Protect"] = "protect"] = "Protect";
})(Channel = exports.Channel || (exports.Channel = {}));
var DocumentType;
(function (DocumentType) {
    DocumentType[DocumentType["OpenAPI2"] = "OpenAPI2"] = "OpenAPI2";
    DocumentType[DocumentType["OpenAPI3"] = "OpenAPI3"] = "OpenAPI3";
    DocumentType[DocumentType["LiterateConfiguration"] = "LiterateConfiguration"] = "LiterateConfiguration";
    DocumentType[DocumentType["Unknown"] = "Unknown"] = "Unknown";
})(DocumentType = exports.DocumentType || (exports.DocumentType = {}));
let resolveAutoRest;
let rejectAutoRest;
exports.AutoRest = new Promise((r, j) => {
    resolveAutoRest = r;
    rejectAutoRest = j;
});
let coreModule = undefined;
let busy = false;
let modulePath = undefined;
/**
 * Returns the command-line application entrypoint for autorest-core, bootstrapping the core if necessary
 *
 * If initialize has already been called, then it returns the version that was initialized, regardless of parameters
 *
 * @param requestedVersion an npm package reference for the version requested @see {@link https://docs.npmjs.com/cli/install#description}
 *
 * @param minimumVersion - a semver string representing the lowest autorest-core version that is considered acceptable.
 *
 * @see {@link initialize}
 * */
async function getApplicationEntrypoint(logger, requestedVersion = "latest-installed", minimumVersion) {
    if (!modulePath && !busy) {
        // if we haven't already got autorest-core, let's do that now with the default settings.
        // eslint-disable-next-line @typescript-eslint/no-use-before-define
        await initialize(logger, requestedVersion, minimumVersion);
    }
    return (0, autorest_as_a_service_1.resolveEntrypoint)(modulePath, "app");
}
exports.getApplicationEntrypoint = getApplicationEntrypoint;
/**
 * Initializes the AutoRest-core module, bootstrapping the core from npm if required.
 *
 * @param requestedVersion an npm package reference for the version requested @see {@link https://docs.npmjs.com/cli/install#description}
 *
 * a) a folder containing a program described by a package.json file
 * b) a gzipped tarball containing (a)
 * c) a url that resolves to (b)
 * d) a <name>@<version> that is published on the registry {@link https://docs.npmjs.com/misc/registry}) with (c)
 * e) a <name>@<tag> (see npm-dist-tag) that points to (d)
 * f) a <name> that has a "latest" tag satisfying (e)
 * g) a <git remote url> that resolves to (a)
 *
 * @param minimumVersion - a semver string representing the lowest autorest-core version that is considered acceptable.
 */
async function initialize(logger, requestedVersion = "latest-installed", minimumVersion) {
    if (modulePath) {
        return;
    }
    if (busy) {
        throw new Error("initialize is already in progress.");
    }
    busy = true;
    try {
        await (0, autorest_as_a_service_1.ensureAutorestHome)();
        try {
            // did they pass in a path first?
            const localVersion = (0, path_1.resolve)(requestedVersion);
            // try to use a specified folder
            modulePath = await (0, autorest_as_a_service_1.resolveEntrypoint)(localVersion, "module");
            if (modulePath) {
                return;
            }
        }
        catch (E) {
            // no local version
        }
        // logic to resolve and optionally install a autorest core package.
        // will throw if it's not doable.
        const selectedVersion = await (0, autorest_as_a_service_1.selectVersion)(logger, requestedVersion, false, minimumVersion);
        modulePath = await (0, autorest_as_a_service_1.resolveEntrypoint)(await selectedVersion.modulePath, "module");
        if (!modulePath) {
            rejectAutoRest(new Error(`Unable to start AutoRest Core from ${requestedVersion}/${await selectedVersion.modulePath}`));
            throw new Error(`Unable to start AutoRest Core from ${requestedVersion}/${await selectedVersion.modulePath}`);
        }
    }
    finally {
        busy = false;
    }
}
exports.initialize = initialize;
/** Bootstraps the core module if it's not already done and returns the AutoRest class. */
async function ensureCoreLoaded(logger) {
    if (!modulePath && !busy) {
        // if we haven't already got autorest-core, let's do that now with the default settings.
        await initialize(logger);
    }
    if (modulePath && !coreModule) {
        // get the library entrypoint
        coreModule = await (0, autorest_as_a_service_1.runCoreWithRequire)(modulePath, "main");
        // assign the type to the Async Class Identity
        resolveAutoRest(coreModule.AutoRest);
    }
    // wait for class definition
    return await exports.AutoRest;
}
/**
 * Creates an instance of the AutoRest engine. Will call {@link initialize} with default values to bootstrap AutoRest core if necessary.
 *
 * @param fileSystem - the {@link IFileSystem} implementation that will be used to acquire files
 *
 * Note: http:/https:/mem: schemes are handled internally in AutoRest and the IFilesystem will not call
 * the IFileSystem methods.
 *
 *
 * @param configFileOrFolderUri - a URI pointing to the folder or autorest configuration file
 */
async function create(logger, fileSystem, configFileOrFolderUri) {
    if (!modulePath && !busy) {
        // if we haven't already got autorest-core, let's do that now with the default settings.
        await initialize(logger);
    }
    if (modulePath && !coreModule) {
        // get the library entrypoint
        coreModule = await (0, autorest_as_a_service_1.runCoreWithRequire)(modulePath, "main");
        // assign the type to the Async Class Identity
        resolveAutoRest(coreModule.AutoRest);
    }
    // wait for class definition
    const CAutoRest = await exports.AutoRest;
    // return new instance of the AutoRest interface.
    return new CAutoRest(fileSystem, configFileOrFolderUri);
}
exports.create = create;
/**
 *  Given a document's content, does this represent a openapi document of some sort?
 *
 * @param content - the document content to evaluate
 */
async function isOpenApiDocument(logger, content) {
    await ensureCoreLoaded(logger);
    return coreModule.IsOpenApiDocument(content);
}
exports.isOpenApiDocument = isOpenApiDocument;
/** Determines the document type based on the content of the document
 *
 * @returns Promise<DocumentType> one of:
 *  -  DocumentType.LiterateConfiguration - contains the magic string '\n> see https://aka.ms/autorest'
 *  -  DocumentType.OpenAPI2 - $.swagger === "2.0"
 *  -  DocumentType.OpenAPI3 - $.openapi === "3.0.0"
 *  -  DocumentType.Unknown - content does not match a known document type
 *
 * @see {@link DocumentType}
 */
async function identifyDocument(logger, content) {
    await ensureCoreLoaded(logger);
    return await coreModule.IdentifyDocument(content);
}
exports.identifyDocument = identifyDocument;
/**
 * Processes a document (yaml, markdown or JSON) and returns the document as a JSON-encoded document text
 * @param content - the document content
 *
 * @returns the content as a JSON string (not a JSON DOM)
 */
async function toJSON(logger, content) {
    await ensureCoreLoaded(logger);
    return await coreModule.LiterateToJson(content);
}
exports.toJSON = toJSON;


/***/ }),

/***/ "assert":
/***/ ((module) => {

module.exports = require("assert");;

/***/ }),

/***/ "async_hooks":
/***/ ((module) => {

module.exports = require("async_hooks");;

/***/ }),

/***/ "buffer":
/***/ ((module) => {

module.exports = require("buffer");;

/***/ }),

/***/ "child_process":
/***/ ((module) => {

module.exports = require("child_process");;

/***/ }),

/***/ "constants":
/***/ ((module) => {

module.exports = require("constants");;

/***/ }),

/***/ "crypto":
/***/ ((module) => {

module.exports = require("crypto");;

/***/ }),

/***/ "dns":
/***/ ((module) => {

module.exports = require("dns");;

/***/ }),

/***/ "events":
/***/ ((module) => {

module.exports = require("events");;

/***/ }),

/***/ "fs":
/***/ ((module) => {

module.exports = require("fs");;

/***/ }),

/***/ "http":
/***/ ((module) => {

module.exports = require("http");;

/***/ }),

/***/ "https":
/***/ ((module) => {

module.exports = require("https");;

/***/ }),

/***/ "net":
/***/ ((module) => {

module.exports = require("net");;

/***/ }),

/***/ "os":
/***/ ((module) => {

module.exports = require("os");;

/***/ }),

/***/ "path":
/***/ ((module) => {

module.exports = require("path");;

/***/ }),

/***/ "process":
/***/ ((module) => {

module.exports = require("process");;

/***/ }),

/***/ "querystring":
/***/ ((module) => {

module.exports = require("querystring");;

/***/ }),

/***/ "readline":
/***/ ((module) => {

module.exports = require("readline");;

/***/ }),

/***/ "stream":
/***/ ((module) => {

module.exports = require("stream");;

/***/ }),

/***/ "string_decoder":
/***/ ((module) => {

module.exports = require("string_decoder");;

/***/ }),

/***/ "tls":
/***/ ((module) => {

module.exports = require("tls");;

/***/ }),

/***/ "tty":
/***/ ((module) => {

module.exports = require("tty");;

/***/ }),

/***/ "url":
/***/ ((module) => {

module.exports = require("url");;

/***/ }),

/***/ "util":
/***/ ((module) => {

module.exports = require("util");;

/***/ }),

/***/ "vm":
/***/ ((module) => {

module.exports = require("vm");;

/***/ }),

/***/ "zlib":
/***/ ((module) => {

module.exports = require("zlib");;

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		var cachedModule = __webpack_module_cache__[moduleId];
/******/ 		if (cachedModule !== undefined) {
/******/ 			return cachedModule.exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			id: moduleId,
/******/ 			loaded: false,
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = __webpack_modules__;
/******/ 	
/******/ 	// the startup function
/******/ 	__webpack_require__.x = () => {
/******/ 		// Load entry module and return exports
/******/ 		// This entry module depends on other loaded chunks and execution need to be delayed
/******/ 		var __webpack_exports__ = __webpack_require__.O(undefined, ["vendors-common_temp_node_modules_pnpm_azure-tools_uri_3_1_1_node_modules_azure-tools_uri_dist-d8365b","src_autorest-as-a-service_ts"], () => (__webpack_require__("./src/exports.ts")))
/******/ 		__webpack_exports__ = __webpack_require__.O(__webpack_exports__);
/******/ 		return __webpack_exports__;
/******/ 	};
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/chunk loaded */
/******/ 	(() => {
/******/ 		var deferred = [];
/******/ 		__webpack_require__.O = (result, chunkIds, fn, priority) => {
/******/ 			if(chunkIds) {
/******/ 				priority = priority || 0;
/******/ 				for(var i = deferred.length; i > 0 && deferred[i - 1][2] > priority; i--) deferred[i] = deferred[i - 1];
/******/ 				deferred[i] = [chunkIds, fn, priority];
/******/ 				return;
/******/ 			}
/******/ 			var notFulfilled = Infinity;
/******/ 			for (var i = 0; i < deferred.length; i++) {
/******/ 				var [chunkIds, fn, priority] = deferred[i];
/******/ 				var fulfilled = true;
/******/ 				for (var j = 0; j < chunkIds.length; j++) {
/******/ 					if ((priority & 1 === 0 || notFulfilled >= priority) && Object.keys(__webpack_require__.O).every((key) => (__webpack_require__.O[key](chunkIds[j])))) {
/******/ 						chunkIds.splice(j--, 1);
/******/ 					} else {
/******/ 						fulfilled = false;
/******/ 						if(priority < notFulfilled) notFulfilled = priority;
/******/ 					}
/******/ 				}
/******/ 				if(fulfilled) {
/******/ 					deferred.splice(i--, 1)
/******/ 					result = fn();
/******/ 				}
/******/ 			}
/******/ 			return result;
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/compat get default export */
/******/ 	(() => {
/******/ 		// getDefaultExport function for compatibility with non-harmony modules
/******/ 		__webpack_require__.n = (module) => {
/******/ 			var getter = module && module.__esModule ?
/******/ 				() => (module['default']) :
/******/ 				() => (module);
/******/ 			__webpack_require__.d(getter, { a: getter });
/******/ 			return getter;
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/ensure chunk */
/******/ 	(() => {
/******/ 		__webpack_require__.f = {};
/******/ 		// This file contains only the entry chunk.
/******/ 		// The chunk loading function for additional chunks
/******/ 		__webpack_require__.e = (chunkId) => {
/******/ 			return Promise.all(Object.keys(__webpack_require__.f).reduce((promises, key) => {
/******/ 				__webpack_require__.f[key](chunkId, promises);
/******/ 				return promises;
/******/ 			}, []));
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/get javascript chunk filename */
/******/ 	(() => {
/******/ 		// This function allow to reference async chunks and sibling chunks for the entrypoint
/******/ 		__webpack_require__.u = (chunkId) => {
/******/ 			// return url for filenames based on template
/******/ 			return "" + chunkId + ".js";
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/node module decorator */
/******/ 	(() => {
/******/ 		__webpack_require__.nmd = (module) => {
/******/ 			module.paths = [];
/******/ 			if (!module.children) module.children = [];
/******/ 			return module;
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/require chunk loading */
/******/ 	(() => {
/******/ 		// no baseURI
/******/ 		
/******/ 		// object to store loaded chunks
/******/ 		// "1" means "loaded", otherwise not loaded yet
/******/ 		var installedChunks = {
/******/ 			"exports": 1
/******/ 		};
/******/ 		
/******/ 		__webpack_require__.O.require = (chunkId) => (installedChunks[chunkId]);
/******/ 		
/******/ 		var installChunk = (chunk) => {
/******/ 			var moreModules = chunk.modules, chunkIds = chunk.ids, runtime = chunk.runtime;
/******/ 			for(var moduleId in moreModules) {
/******/ 				if(__webpack_require__.o(moreModules, moduleId)) {
/******/ 					__webpack_require__.m[moduleId] = moreModules[moduleId];
/******/ 				}
/******/ 			}
/******/ 			if(runtime) runtime(__webpack_require__);
/******/ 			for(var i = 0; i < chunkIds.length; i++)
/******/ 				installedChunks[chunkIds[i]] = 1;
/******/ 			__webpack_require__.O();
/******/ 		};
/******/ 		
/******/ 		// require() chunk loading for javascript
/******/ 		__webpack_require__.f.require = (chunkId, promises) => {
/******/ 			// "1" is the signal for "already loaded"
/******/ 			if(!installedChunks[chunkId]) {
/******/ 				if(true) { // all chunks have JS
/******/ 					installChunk(require("./" + __webpack_require__.u(chunkId)));
/******/ 				} else installedChunks[chunkId] = 1;
/******/ 			}
/******/ 		};
/******/ 		
/******/ 		// no external install chunk
/******/ 		
/******/ 		// no HMR
/******/ 		
/******/ 		// no HMR manifest
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/startup chunk dependencies */
/******/ 	(() => {
/******/ 		var next = __webpack_require__.x;
/******/ 		__webpack_require__.x = () => {
/******/ 			__webpack_require__.e("vendors-common_temp_node_modules_pnpm_azure-tools_uri_3_1_1_node_modules_azure-tools_uri_dist-d8365b");
/******/ 			__webpack_require__.e("src_autorest-as-a-service_ts");
/******/ 			return next();
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
/******/ 	
/******/ 	// run startup
/******/ 	var __webpack_exports__ = __webpack_require__.x();
/******/ 	module.exports = __webpack_exports__;
/******/ 	
/******/ })()
;
//# sourceMappingURL=exports.js.map