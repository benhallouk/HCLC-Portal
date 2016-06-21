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
3. Live chat with AI]
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

# How can I get involved
As organisation, we highly believe in social coding and open collaboration.
We would like to encourage any of the GitHub developers to contribute to hackney-Portal Project by using Git flow.

# Contributing to Hackney Portal

We would love for you to contribute to Hackney Portal and help make it even better than it is
today! As a contributor, here are the guidelines we would like you to follow:

 - [Code of Conduct](#coc)
 - [Question or Problem?](#question)
 - [Issues and Bugs](#issue)
 - [Feature Requests](#feature)
 - [Submission Guidelines](#submit)
 - [Coding Rules](#rules)
 - [Commit Message Guidelines](#commit)

As contributors and maintainers of the Hackney Portal, we pledge to respect everyone who contributes 
by posting issues, updating documentation, submitting pull requests, providing feedback in comments, 
and any other activities.Please read and follow our [Code of Conduct][coc].

## <a name="coc"></a> Code of Connduct


## <a name="question"></a> Got a Question or Problem?

If you have questions about how to *use* Hackney Portal, please note that Hackney Portal is still in early developer preview, and the core team's capacity to answer usage questions is limited. 

## <a name="issue"></a> Found an Issue?
If you find a bug in the source code or a mistake in the documentation, you can help us by
[submitting an issue](#submit-issue) to our [GitHub Repository](https://github.com/fresh-innovate/HCLC-Portal). Even better, you can
[submit a Pull Request](#submit-pr) with a fix.

## <a name="feature"></a> Want a Feature?
You can *request* a new feature by [submitting an issue](#submit-issue) to our [GitHub
Repository](https://github.com/fresh-innovate/HCLC-Portal). If you would like to *implement* a new feature, please submit an issue with
a proposal for your work first, to be sure that we can use it. Hackney Portal is in developer preview
and we are not ready to accept major contributions ahead of the full release.
Please consider what kind of change it is:

* For a **Major Feature**, first open an issue and outline your proposal so that it can be
discussed. This will also allow us to better coordinate our efforts, prevent duplication of work,
and help you to craft the change so that it is successfully accepted into the project.
* **Small Features** can be crafted and directly [submitted as a Pull Request](#submit-pr).

## <a name="submit"></a> Submission Guidelines

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

## <a name="rules"></a> Coding Rules
To ensure consistency throughout the source code, keep these rules in mind as you are working:

* All features or bug fixes **must be tested** by one or more specs (unit-tests).
* All public API methods **must be documented**. (Details TBC).
* We follow [Google's JavaScript Style Guide][js-style-guide], but wrap all code at
  **100 characters**.

## <a name="commit"></a> Commit Message Guidelines

We have very precise rules over how our git commit messages can be formatted.  This leads to **more
readable messages** that are easy to follow when looking through the **project history**.  But also,
we use the git commit messages to **generate the Angular change log**.

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

# Code Standards
To ensure quality and consistency throughout the project source code, 
we recommend you to keep up to date with the following guidelines:

- [Google HTML/CSS Style Guide][html-css-style-guide]
- [Google's JavaScript Style Guide][js-style-guide]
- [Google's AngularJS Style Guide][angularjs-style-guide]
- [ASP.NET Doc Style Guide][aspnet-style-guide] 
- [C# Programming Guide][csharp-style-guide]

# Git Flow
As organisation we have strong preference for Agile methodologies, in particular Scrum, we choose Gitflow to improve our work team.Every contributor must use Git flow

![alt tag](https://raw.githubusercontent.com/benhallouk/demo-2/master/src/workflow.png)

[html-css-style-guide]: https://google.github.io/styleguide/htmlcssguide.xml
[js-style-guide]: https://google.github.io/styleguide/javascriptguide.xml
[angularjs-style-guide]: https://google.github.io/styleguide/angularjs-google-style.html
[aspnet-style-guide]: https://google.github.io/styleguide/angularjs-google-style.html
[csharp-style-guide]: https://msdn.microsoft.com/en-gb/library/ff926074.aspx

###  Git Flow
As organisation we strong preference for Agile methodologies, in particular Scrum, we choose Gitflow to improve our work team, please be advsied that every contributor must use Git flow

![alt tag](https://raw.githubusercontent.com/benhallouk/demo-2/master/src/workflow.png)

## Before starting
It is **strongly** recommended that you have some basic notions of how git works

Installing git-flow
-------------------
### How to install in from the source code
````
$ git clone --recursive git://github.com/
$ cd gitflow
$ sudo make install
````
This will install git-flow in /usr/local. And we are ready to go.

Initializing git-flow on a newly created repository
---------------------------------------------------
### Clone it!
#### Internally hosted repositories
````
$ git clone https://github.com/fresh-innovate/HCLC-Portal
````

#### Externally hosted repositories (GitHub)
The process is exactly the same if the repository was initially available only on GitHub: 

````
$ git clone https://github.com/fresh-innovate/HCLC-Portal.git
````

#### Local repositories
Nothing forbids you to use git-flow into local-only repositories

### Initialize git-flow
We have to configure git-flow for the current repository before start using it.

````
$ cd example
$ git flow init
````

Now git-flow is going to ask you a couple of question about the default names for the master, develop, feature, release, hotfix and support branches. As the whole point of this guide is to create a solid standard for the version control model, you should just accept the default values.
So after you hit return a couple of times, your command line should look like this:

````
No branches exist yet. Base branches must be created now.
Branch name for production releases: [master] 
Branch name for "next release" development: [develop] 
How to name your supporting branch prefixes?
Feature branches? [feature/] 
Release branches? [release/] 
Hotfix branches? [hotfix/] 
Support branches? [support/] 
Version tag prefix? []
````

You will be automatically checked out to the develop branch, where you can start working normally.

#### Push your branches to the origin
As this repository is totally fresh, the 'master' and 'develop' branches only exist into your local copy. You need to push them to the origin in order to make them avaliable for everyone.

````
$ touch README
$ git add README
$ git commit -m "First commit!"
$ git push origin develop
$ git checkout master
$ git push origin master
````

Initializing git-flow on an existing repository
-----------------------------------------------
You **must** initialize git-flow on your local copy of the repository before start using it. 



There is one very important fact to keep in mind here. As git-flow **must** be initialized and configured on any repository before being used.

### Clone it!
Obviously, you need to get a hold on a copy of the repository you are trying to work with. So first thing to do is to clone it.

#### From GitHub

````
$ git clone https://github.com/fresh-innovate/HCLC-Portal.git
````
### Initialize git-flow
Now it's time to configure git-flow. Let's kick in!

````
$ git flow init
````

It will ask you a couple of questions, being the first ones regarding the master and develop branches. Consider what we said above regarding the naming conventions, and if you going  all standard (recommended!), all you will need to do is press return a couple of times and your command line should look similar to this:

````
Which branch should be used for bringing forth production releases?
   - develop
   - master
Branch name for production releases: [master] 

Which branch should be used for integration of the "next release"?
   - develop
Branch name for "next release" development: [develop] 

How to name your supporting branch prefixes?
Feature branches? [feature/] 
Release branches? [release/] 
Hotfix branches? [hotfix/] 
Support branches? [support/] 
Version tag prefix? [] 
````

####Commit, commit, commit!
This is more general git good practice but it worth remembering, don't hold the code for yourself for too long, commit it often so it won't cause any conflict later on. 

####Merge, merge, merge!
On the other way around, you always want to have the updates that your team produced merged as soon as possible into your code, so you don't work on top of outdated code. 

####Fetching and pushing
You might be asking yourself when it's good time to push and when it's good time to fetch... The short answer for that is: always fetch & merge before you push, always commit before you fetch. An simple flow that works well is to `commit (it's ok to hold a couple if they are really small) > fetch > merge > push`. In a real world scenario that should be done like that:

#####Commiting
After staging your changes:

````
$ git commit -m "Your commit description"
````

#####Fetching (all the remotes!)

````
$ git fetch origin
$ git fetch github
````

#####Merging
If after fetching you see that there are changes coming, you need to merge them into your branches.
````
$ git checkout develop
$ git merge origin/develop 
$ git merge github/develop 
$ git checkout master
$ git merge origin/master 
$ git merge github/master 
````

##### Pushing

````
$ git push origin
$ git push github
````

Notice that we are running the `git push` command without any branch name, that will push all the branches. You could of course push them individually using the `git push {branch-name}`.

##### Don't forget the tags!
In case you did a release or hotfix you probably also added a tag to your commit the 'master' branch. In that case you will need to *also* push the tags explicitly. This is done by adding the `--tags` argument at the end of the push command.

````
$ git push origin --tags
$ git push github --tags
