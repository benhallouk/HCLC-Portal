![alt tag](https://raw.githubusercontent.com/benhallouk/demo-2/master/src/fresh-innovate-banner.png)

# Introduction

Fresh Innovate wins 24hr Hackathon; Having won the hackathon, we are now require to build an application which will include two portals, one for lawyers and one for clients. Lawyers can manage the cases remotely, and clients can feed in the basic information for their case using an easy-to-follow online guide with automatic translation services, spoken as well as written text services and a live chat facility that uses artificial intelligence to read the context of questions. The product will need to mobile and user friendly with easy accessibility

### Features and technology:
1. Easily accessible, device compatible website and language supported through speech and text
Help users of all devices and platform to get access to information as it was mentioned that most clients have smartphones. We used HTML5, AngularJS, Bootstrap, SASS and CSS3 to implement this solution. Bootstrap was chosen because it is a cutting edge technology invented by twitter and is used widely by the web community and is known to resolve a lot of device specific issues. We chose this technology due to its large community of contributors helping improve GoogleAPI which also has Big Data support with super computer utilizing AI to help with maintain their Big Data.

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

###  Git Flow
As organisation we strong preference for Agile methodologies, in particular Scrum, we choose Gitflow to improve our work team, please be advsied that every contributor must use Git flow

![alt tag](https://raw.githubusercontent.com/benhallouk/demo-2/master/src/workflow.png)

## Before starting
It is **strongly** recommended that you have some basic notions of how git works before you start digging into anything on this page.

### Must see links (seriously)
* [A successful Git branching model](http://nvie.com/posts/a-successful-git-branching-model/) (Original blog post where GitFlow as presented)
* [Why aren't you using Git Flow?](http://jeffkreeftmeijer.com/2010/why-arent-you-using-git-flow/) (Article that opened my eyes to the neat git-flow tools for using the GitFlow model - a lot of the stuff mentioned there is going to be repeated here)
* [How to use a scalable Git branching model called git-flow](http://buildamodule.com/video/change-management-and-version-control-deploying-releases-features-and-fixes-with-git-how-to-use-a-scalable-git-branching-model-called-gitflow) (Nice visual representation of how GitFlow works)
* [On the path with git-flow](http://codesherpas.com/screencasts/on_the_path_gitflow.mov) (Very didactic screen cast with real world usage of git-flow)

Installing git-flow
-------------------
### How to install in from the source code
````
$ git clone --recursive git://github.com/
$ cd gitflow
$ sudo make install
````
This will install git-flow in /usr/local. And we are ready to go.

For more in depth information (different platforms, etc), follow the instructions of the [git-flow repository on GitHub](https://github.com/nvie/gitflow). There you will also find a lot of extra information about the project and all the other goodies GitHub provides.

Initializing git-flow on a newly created repository
---------------------------------------------------
### Clone it!
#### Internally hosted repositories
````
$ git clone https://github.com/fresh-innovate/HCLC-Portal.git
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
If you did your homework and checked out all the links listed in the beginning of this document, you should be starting to realize that not all of the development should occur on the develop branch itself. The develop branch is place where the more general, shared development should occurs. Any bigger, specialized development, that is likely to be developed by only one person (a.k.a. feature) should be done in a *feature* branch (:D yes, thats why they exist!). Feature branches are only temporary and should remain local (no need to push them), unless other developers are also going to work with it.

#### Push your branches to the origin
As this repository is totally fresh, the 'master' and 'develop' branches only exist into your local copy. You need to push them to the origin in order to make them avaliable for everyone.

Git might complain though if you try to push a totally empty commit. This a good time to add that nice README (or a basic .gitignore file maybe?). In case you really don't have anything to say now, just create empty files.

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

If your development branch is called anything else than 'develop' and your release branch is called anything else than 'master' (very unlikely), you have two options:

* Don't rename your branches at all, and just tell git-flow to use the existing names. This might be necessary in case the repository is already being used by lots of people and renaming the branches would cause a lot of confusion between developers. Honestly that will hardly be the case within the scope of our projects.
* Use the default naming conventions and merge your custom named develop/master branches into the standard ones.

There is one very important fact to keep in mind here. As git-flow **must** be initialized and configured on any repository before being used, you need to inform all the contributors what is the naming conventions being used. Thats a good reason to justify why it's strongly recommended to stick with default names (the whole point it's to make things easier, isn't it?!).

###Clone it!
Obviously, you need to get a hold on a copy of the repository you are trying to work with. So first thing to do is to clone it.

#### From GitHub

````
$ git clone https://github.com/fresh-innovate/HCLC-Portal.git
````
### Track all the branches!
By default `git clone` will only clone the master branch in your local copy, but you actually want to get a hold on and track all the remote branches (or at least both master & develop, where the action really happens). Unfortunately git won't provide any built-in method for doing that. But fortunately some good soul on stackoverflow* gave us a one-line bash script alternative that will clone and track all the remote branches into local branches with the same name. So after you've cloned your repository, all you gotta do is:

````
$ for remote in `git branch -r | grep -v master `; do git checkout --track $remote ; done
````

*Here's the [original stackoverflow thread where the script was found](http://stackoverflow.com/questions/379081/track-all-remote-git-branches-as-local-branches).

###Initialize git-flow
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



Working with remotes (GitHub)
--------------------------------------------------------
Although git-flow has some interesting built in functionality for keeping your local copy up-to-date with your origin remote (like fetching it before finishing a release or hotfix), it is not really designed to handle multiple remotes scenarios. So, bare in mind that it obviously won't do any magical work. You will still need to configure your remotes and fetch and push them manually...


### Configure your remotes!
#### Repositories with only one remote
If you are going to work with a repository with only one remote (e.g. if you are an Oakwood developer working a project that won't need any external collaborators and therefore will only be hosted @ minieken, or if you are an external collaborator that will have GitHub as the only version control server you need to keep track of), there's no need to configure anything. When you've cloned the repository, git automatically set the one-and-only remote you will use: 'origin'.

#### Repositories with multiple remotes
If you are working in a project that will need more than one remote (e.g. hosted on both minieken and GitHub), you need to configure your remotes in order to be able to fetch and push them easily.
Git will automatically set your 'origin' remote to be the location you cloned your repository from, so, if you cloned the repository from minieken, your origin is already set for you and all you need to do is to configure the 'github' remote. However if you cloned the repository from GitHub, you will need to reconfigure 'origin' so it point's to the right place. This is very easy to do:

````
$ git remote https://github.com/fresh-innovate/HCLC-Portal.git
````

Now you can go ahead and add the GitHub remote:

````
$ git remote add gihub https://github.com/fresh-innovate/HCLC-Portal.git
````

Ok, now all the remotes are set!

###Keeping everything synced
To avoid any unnecessary conflicts we should always keep all our branches and remotes up-to-date with each other. Although the internal and external server should always "mirror" each other, there isn't any automated script that will handle that, so it's a very important practice to always fetch from and push to all the remotes regularly. This "distributed synchronization system" is very simple and horizontal; if integrated these practices into your workflow, you won't even need to think about it. So let's boil it down to some good user practices...

####Commit, commit, commit!
This is more general git good practice but it worth remembering, don't hold the code for yourself for too long, commit it often so it won't cause any conflict later on. If you are working on a very specific feature that has it own branch, try to brake the development into small milestones and merge your progress back to the develop branch.

####Merge, merge, merge!
On the other way around, you always want to have the updates that your team produced merged as soon as possible into your code, so you don't work on top of outdated code. If you are working directly on the develop branch, that is a no-brainer: every time you fetch and merge the remotes, all the updates will be automatically introduced in the code you are working with. But if you are working on a separate, feature branch, the updates in develop won't reach your code until you explicitly merge develop into your branch.

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

The above lines could also be replaced by the `$ git remote update` command. This will automatically fetch all your remotes.

#####Merging
If after fetching you see that there are changes coming, you need to merge them into your branches. It's  likely that the master branch won't be updated so often as the develop branch, but in anyway, it won't hurt to run the merge command for all of them so you have a clear conscious that everything was updated correctly.

````
$ git checkout develop
$ git merge origin/develop 
$ git merge github/develop 
$ git checkout master
$ git merge origin/master 
$ git merge github/master 
````

If everyone in the Oakwood team is pushing regularly to both 'origin' and 'github', after you run `$ git merge github/{brach-name}` it's almost sure you will get the `Already up-to-date.` message, the reason however that you should always check for 'github' is to make sure that you don't miss out any changes introduced by external contributors, in that case 'github' is the only remote your repositories will ever interface.

#####Pushing
Time to make your changes public! Don't forget to push to all the remotes.

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
````

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

## <a name="coc"></a> Code of Conduct
Help us keep Hackney Portal open and inclusive. Please read and follow our [Code of Conduct][coc].

## <a name="question"></a> Got a Question or Problem?

If you have questions about how to *use* Hackney Portal,
please note that Hackney Portal is still in early developer preview, and the core team's capacity to answer usage questions is limited. 

## <a name="issue"></a> Found an Issue?
If you find a bug in the source code or a mistake in the documentation, you can help us by
[submitting an issue](#submit-issue) to our [GitHub Repository][github]. Even better, you can
[submit a Pull Request](#submit-pr) with a fix.

## <a name="feature"></a> Want a Feature?
You can *request* a new feature by [submitting an issue](#submit-issue) to our [GitHub Repository](https://github.com/fresh-innovate/HCLC-Portal). If you would like to *implement* a new feature, please submit an issue with
a proposal for your work first, to be sure that we can use it. Angular 2 is in developer preview
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

* **Overview of the Issue** - if an error is being thrown a non-minified stack trace helps
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

* Search [GitHub](https://github.com/fresh-innovate/HCLC-Portal/pulls) for an open or closed PR
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
  * Re-run the Angular 2 test suites for JS and Dart to ensure tests are still passing.
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

Footer should contain a [closing reference to an issue](https://help.github.com/articles/closing-issues-via-commit-messages/) if any.

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

[html-css-style-guide]: https://google.github.io/styleguide/htmlcssguide.xml
[js-style-guide]: https://google.github.io/styleguide/javascriptguide.xml
[angularjs-style-guide]: https://google.github.io/styleguide/angularjs-google-style.html
[aspnet-style-guide]: https://google.github.io/styleguide/angularjs-google-style.html
[csharp-style-guide]: https://msdn.microsoft.com/en-gb/library/ff926074.aspx
