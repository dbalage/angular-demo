# Visual Studio Code

1. Create folder

2. Npm init
    ``` 
        npm init
    ``` 
    Next, next, finish...
    Létrejön a `package.json`

3. Edit dependencies
    ``` javascript
        {
            "name": "angular-tutorial",
            "version": "1.0.0",
            "license": "ISC",
            "scripts": {
                "ng": "ng",
                "start": "ng serve",
                "test": "ng test",
                "lint": "ng lint",
                "e2e": "ng e2e"
            },
                "dependencies": {
                "@angular/common": "^2.4.0",
                "@angular/compiler": "^2.4.0",
                "@angular/core": "^2.4.0",
                "@angular/forms": "^2.4.0",
                "@angular/http": "^2.4.0",
                "@angular/platform-browser": "^2.4.0",
                "@angular/platform-browser-dynamic": "^2.4.0",
                "@angular/router": "^3.4.0",
                "core-js": "^2.4.1",
                "rxjs": "^5.0.1",
                "ts-helpers": "^1.1.1",
                "zone.js": "^0.7.2"
            },
                "devDependencies": {
                "@angular/cli": "1.0.0-beta.31",
                "@angular/compiler-cli": "^2.4.0",
                "@types/node": "^6.0.42",
                "ts-node": "1.2.1",
                "tslint": "^4.3.0",
                "typescript": "~2.0.0"
            }
        }
    ``` 
4. Install packages
    ``` 
        npm install
    ``` 