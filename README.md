![alt tag](https://raw.githubusercontent.com/benhallouk/demo-2/master/src/fresh-innovate-banner.png)

# Introduction

Fresh Innovate wins 24hr Hackathon; Having won the hackathon, we are now require to build an application which will include two portals, one for lawyers and one for clients. Lawyers can manage the cases remotely, and clients can feed in the basic information for their case using an easy-to-follow online guide with automatic translation services, spoken as well as written text services and a live chat facility that uses artificial intelligence to read the context of questions. The product will need to mobile and user friendly with easy accessibility

### Features and technology:
1. Easily accessible, device compatible website and language supported through speech and text
Help users of all devices and platform to get access to information as it was mentioned that most clients have smartphones. We used HTML5, Hackney PortalJS, Bootstrap, SASS and CSS3 to implement this solution. Bootstrap was chosen because it is a cutting edge technology invented by twitter and is used widely by the web community and is known to resolve a lot of device specific issues. We chose this technology due to its large community of contributors helping improve GoogleAPI which also has Big Data support with super computer utilizing AI to help with maintain their Big Data.

2. Portal and Live chat with AI assistance
The Portal helps monitor and track progress of an open cases for both users and Lawyers. This will help free up lawyers time and resource.
Live chat was a prove of concept with Artificial Intelligence as the intended back engine. This will drive down calls to the Centre by providing tailored advice.

3. Portal add-ons and document upload
Registration process - included a specific filtering criteria to reduce ineligible clients from unnecessary opening a case.

4. Analytics - helps the Centre to gather specific information in order to improve their service.

5. Referral - which is part of add-ons was implemented to allow administrators and lawyers to refer their cases to other Law Centres.
The platform was developed using ASP.NET MVC framework,
Each of these problems were fed into our 3 hour iteration with a working solution completed by the end of each iteration.

### To implement the final product, the follwoing features and will need to be implemented:
1. Login/Registration
2. Translation per language
3. Live chat with AI
4. Decision tree per category
5. Case list / ticket details#
6. Alerts and notifications (auto/manual)
7. Documents upload and storage
8. Digitally signed forms
9. User profile page
10. Calendar
11. Referral to other organisation
12. Analytics
13. Adding new client by admins

### Getting started with this project

This project is using the latest and greatest technologies including:. ASP.NET MVC, [Angular 2] with [TypeScript], [Gulp], [Bootstrap] and [Sass].

To get started you need:
-------------
- 10 Minutes or less
- [Visual Studio 2015] and [Visual Studio Code]
- [Node.js] installed on your machine
- and the most important [Git]

[Visual Studio 2015]: <https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx>
[Visual Studio Code]: <https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx>
[Node.js]: <https://nodejs.org/en/>
[Git]: <https://git-scm.com/downloads>
[Angular 2]: <https://angular.io/>
[TypeScript]: <https://www.typescriptlang.org/>
[Gulp]: <http://gulpjs.com/>
[Bootstrap]: <http://getbootstrap.com/>
[Sass]: <http://sass-lang.com/>

Working with the Code 
-------------
Clone repository to create a local copy on your computer
```sh
git clone https://github.com/fresh-innovate/HCLC-Portal.git
```
Install Node and Angular dependencies
-------------
Change your current directory to Hackney/Client/Portal/src folder
```sh
cd Hackney/Client/portal
```

All the client depandancies including development tools can be installed using the command bellow:
```sh
npm install
```
`node_modules` and `typings` directories should be created during the install.

To build portal transpile all typescript and sass with the run command:

```sh
npm run build
```
`portal` directory should be created during the build inside the main HCLC-Portal folder

To start the development
Go to HCLC-Portal folder and run `Hackney.sln` project file, wait a while `Visual Studio`  install all necessary `packages` and you are ready to do the build.

Then run the command to start the browsersync for pleasant development
```sh
npm run start
```
The application should be displayed in the browser and the `gulp` tool will watch the client side changes and relead and sync the browser automatically.

### Contributing to Hackney Portal

We would love for you to contribute to Hackney Portal and help make it even better than it is
today! As a contributor, here are the guidelines we would like you to follow:

 - [Code of Conduct](#coc)
 - [Question or Problem?](#question)
 - [Issues and Bugs](#issue)
 - [Feature Requests](#feature)
 - [Submission Guidelines](#submit)
 - [Coding Rules](#rules)
 - [Commit Message Guidelines](#commit)

## <a name="coc"></a> Code of Conduct
As contributors and maintainers of the Hackney Portal, we pledge to respect everyone who contributes 
by posting issues, updating documentation, submitting pull requests, providing feedback in comments, 
and any other activities.


### <a name="question"></a> Got a Question or Problem?

If you have questions about how to *use* Hackney Portal, please note that Hackney Portal is still in early developer preview, and the core team's capacity to answer usage questions is limited. 

### <a name="issue"></a> Found an Issue?
If you find a bug in the source code or a mistake in the documentation, you can help us by
[submitting an issue](#submit-issue) to our [GitHub Repository](https://github.com/fresh-innovate/HCLC-Portal). Even better, you can
[submit a Pull Request](#submit-pr) with a fix.

### <a name="feature"></a> Want a Feature?
You can *request* a new feature by [submitting an issue](#submit-issue) to our [GitHub
Repository](https://github.com/fresh-innovate/HCLC-Portal). If you would like to *implement* a new feature, please submit an issue with
a proposal for your work first, to be sure that we can use it. Hackney Portal is in developer preview
and we are not ready to accept major contributions ahead of the full release.
Please consider what kind of change it is:

* For a **Major Feature**, first open an issue and outline your proposal so that it can be
discussed. This will also allow us to better coordinate our efforts, prevent duplication of work,
and help you to craft the change so that it is successfully accepted into the project.
* **Small Features** can be crafted and directly [submitted as a Pull Request](#submit-pr).

### <a name="submit"></a> Submission Guidelines

### <a name="submit-issue"></a> Submitting an Issue
Before you submit an issue, search the archive, maybe your question was already answered.

If your issue appears to be a bug, and hasn't been reported, open a new issue.
Help us to maximize the effort we can spend fixing issues and adding new
features, by not reporting duplicate issues.  Providing the following information will increase the
chances of your issue being dealt with quickly:

* **Motivation for or Use Case** - explain what are you trying to do and why the current behavior is a bug for you
* **Browsers and Operating System** - is this a problem with all browsers?
* **Reproduce the Error** - provide a live example (using [Plunker][plunker],
  [JSFiddle][jsfiddle] or [Runnable][runnable]) or a unambiguous set of steps
* **Related Issues** - has a similar issue been reported before?
* **Suggest a Fix** - if you can't fix the bug yourself, perhaps you can point to what might be
  causing the problem (line of code or commit)

You can file new issues by providing the above information [here](https://github.com/fresh-innovate/HCLC-Portal/issues/new).


### <a name="submit-pr"></a> Submitting a Pull Request (PR)
Before you submit your Pull Request (PR) consider the following guidelines:

* Search [https://github.com/fresh-innovate/HCLC-Portal/pulls) for an open or closed PR
  that relates to your submission. You don't want to duplicate effort.
* Make your changes in a new git branch:

     ```shell
     git checkout -b my-fix-branch master
     ```

* Create your patch, **including appropriate test cases**.
* Follow our [Coding Rules](#rules).
* Run the full Hackney Portal test suite and ensure that all tests pass.
* Commit your changes using a descriptive commit message that follows our
  [commit message conventions](#commit). Adherence to these conventions
  is necessary because release notes are automatically generated from these messages.

     ```shell
     git commit -a
     ```
  Note: the optional commit `-a` command line option will automatically "add" and "rm" edited files.

* Push your branch to GitHub:

    ```shell
    git push origin my-fix-branch
    ```

* In GitHub, send a pull request to `angular:master`.
* If we suggest changes then:
  * Make the required updates.
  * Re-run the Hackney Portal test suites for JS and Dart to ensure tests are still passing.
  * Rebase your branch and force push to your GitHub repository (this will update your Pull Request):

    ```shell
    git rebase master -i
    git push -f
    ```

That's it! Thank you for your contribution!

#### After your pull request is merged

After your pull request is merged, you can safely delete your branch and pull the changes
from the main (upstream) repository:

* Delete the remote branch on GitHub either through the GitHub web UI or your local shell as follows:

    ```shell
    git push origin --delete my-fix-branch
    ```

* Check out the master branch:

    ```shell
    git checkout master -f
    ```

* Delete the local branch:

    ```shell
    git branch -D my-fix-branch
    ```

* Update your master with the latest upstream version:

    ```shell
    git pull --ff upstream master
    ```

### GitFlow
As organisation we have strong preference for Agile methodologies.  We believe that is very well suited to collaboration and scaling the development team.

#### Collaboration
Feature branches make life easier for developers to collaborate on the same feature, because each feature branch is a sandbox where the only changes are the changes necessary to get the new feature working. That makes it very easy to see and follow what each collaborator is doing.

![alt tag](https://raw.githubusercontent.com/benhallouk/demo-2/master/src/workflow.png)

[html-css-style-guide]: https://google.github.io/styleguide/htmlcssguide.xml
[js-style-guide]: https://google.github.io/styleguide/javascriptguide.xml
[angularjs-style-guide]: https://google.github.io/styleguide/angularjs-google-style.html
[aspnet-style-guide]: https://google.github.io/styleguide/angularjs-google-style.html
[csharp-style-guide]: https://msdn.microsoft.com/en-gb/library/ff926074.aspx	
	
### <a name="rules"></a> Coding Rules
To ensure consistency throughout the source code, keep these rules in mind as you are working:

* All features or bug fixes **must be tested** by one or more specs (unit-tests).
* All public API methods **must be documented**. (Details TBC).

To ensure quality and consistency throughout the project source code, 
we recommend you to keep up to date with the following guidelines:

- [Google HTML/CSS Style Guide][html-css-style-guide]
- [Google's JavaScript Style Guide][js-style-guide]
- [Google's AngularJS Style Guide][angularjs-style-guide]
- [ASP.NET Doc Style Guide][aspnet-style-guide] 
- [C# Programming Guide][csharp-style-guide]

### <a name="commit"></a> Commit Message Guidelines

We have very precise rules over how our git commit messages can be formatted.  This leads to **more
readable messages** that are easy to follow when looking through the **project history**.

### Commit Message Format
Each commit message consists of a **header**, a **body** and a **footer**.  The header has a special
format that includes a **type**, a **scope** and a **subject**:

```
<type>(<scope>): <subject>
<BLANK LINE>
<body>
<BLANK LINE>
<footer>
```

The **header** is mandatory and the **scope** of the header is optional.

Any line of the commit message cannot be longer 100 characters! This allows the message to be easier
to read on GitHub as well as in various git tools.

Footer should contain a closing reference to an issue

Example:
```
docs(changelog): update change log to beta.5
```
```
fix(release): need to depend on latest rxjs and zone.js

The version in our package.json gets copied to the one we publish, and users need the latest of these.
```

### Revert
If the commit reverts a previous commit, it should begin with `revert: `, followed by the header of the reverted commit. In the body it should say: `This reverts commit <hash>.`, where the hash is the SHA of the commit being reverted.

### Type
Must be one of the following:

* **feat**: A new feature
* **fix**: A bug fix
* **docs**: Documentation only changes
* **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing
  semi-colons, etc)
* **refactor**: A code change that neither fixes a bug nor adds a feature
* **perf**: A code change that improves performance
* **test**: Adding missing tests or correcting existing tests
* **build**: Changes that affect the build system or external dependencies (example scopes: gulp, broccoli, npm)
* **ci**: Changes to our CI configuration files and scripts (example scopes: Travis, Circle, BrowserStack, SauceLabs)
* **chore**: Other changes that don't modify `src` or `test` files

### Scope
The scope could be anything specifying place of the commit change. For example
`Compiler`, `ElementInjector`, etc.

### Subject
The subject contains succinct description of the change:

* use the imperative, present tense: "change" not "changed" nor "changes"
* don't capitalize first letter
* no dot (.) at the end

### Body
Just as in the **subject**, use the imperative, present tense: "change" not "changed" nor "changes".
The body should include the motivation for the change and contrast this with previous behavior.

### Footer
The footer should contain any information about **Breaking Changes** and is also the place to
reference GitHub issues that this commit **Closes**.

**Breaking Changes** should start with the word `BREAKING CHANGE:` with a space or two newlines. The rest of the commit message is then used for this.

[angular-group]: https://groups.google.com/forum/#!forum/angular
[coc]: https://github.com/angular/code-of-conduct/blob/master/CODE_OF_CONDUCT.md
[commit-message-format]: https://docs.google.com/document/d/1QrDFcIiPjSLDn3EL15IJygNPiHORgU1_OOAqWjiDU5Y/edit#
[corporate-cla]: http://code.google.com/legal/corporate-cla-v1.0.html
[dev-doc]: https://github.com/angular/angular/blob/master/DEVELOPER.md
[github]: https://github.com/angular/angular
[gitter]: https://gitter.im/angular/angular
[individual-cla]: http://code.google.com/legal/individual-cla-v1.0.html
[js-style-guide]: https://google.github.io/styleguide/javascriptguide.xml
[jsfiddle]: http://jsfiddle.net
[plunker]: http://plnkr.co/edit
[runnable]: http://runnable.com
[stackoverflow]: http://stackoverflow.com/questions/tagged/angular