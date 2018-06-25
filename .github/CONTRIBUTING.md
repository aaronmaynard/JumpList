# Contributing to JumpList

:+1::tada: First off, thanks for taking the time to contribute! :tada::+1:

The following is a set of guidelines for contributing to JumpList, which are hosted by [Aaron Maynard][profile] on GitHub. These are mostly guidelines, not rules. Use your best judgment, and feel free to propose changes to this document in a pull request.

#### Table Of Contents

1. [Code of Conduct](#coc)
2. [I don't want to read this whole thing I just have a question!!!](#tldr)
3. [How Can I Contribute](#hcic)  
  a) [Reporting Issues](#ri)  
  b) [Submitting a (good) Issue Report](#sir)  
  c) [Suggesting Enhancements](#se)  
  d) [Your First Code Contribution](#yfcc)  
  e) [Pull Request](#pr)
  
4. [Styleguides](#sg)
5. [Git Commit Messages](#gcm)  
  a) [More++](#more)
  
6. [Additional Notes](#an)  
  a) [Issue and Pull Request Labels](#iprl)  
  -i) [Type of Issue and Issue State](#tiis)  
  -ii) [Pull Request Labels](#prl)
  
7. [Asking For Help](#a4h)

<div id='coc'/>

## Code of Conduct

This project and everyone participating in it is governed by the [JumpList Code of Conduct][CoC]. By participating, you are expected to uphold this code. Please report unacceptable behavior to an administrator on our [Discord][discord] server.

<div id='tldr'/>

## I don't want to read this whole thing I just have a question!!!

> **Note:** Please don't file an issue to ask a question. You'll get faster results by using the resources below.

We have a Discord server where the community chimes in with helpful advice if you have questions.

* [Access the Discord Server][discord]
    * There are many other channels available, check the channel list

<div id='hcic'/>

## How Can I Contribute?

<div id='ri'/>

### Reporting Issues

This section guides you through submitting a bug report for JumpList. Following these guidelines helps maintainers and the community understand your report :pencil:, reproduce the behavior :computer: :computer:, and find related reports :mag_right:.

 When you are creating an issue report, please [include as many details as possible](#sir). Fill out [the required template](issue-template), the information it asks for helps us resolve issues faster.

> **Note:** If you find a **Closed** issue that seems like it is the same thing that you're experiencing, open a new issue and include a link to the original issue in the body of your new one.

<div id='sir'/>

#### How Do I Submit A (Good) Issue Report?

Issues are tracked as [GitHub issues](https://guides.github.com/features/issues/). Create an issue on the repository and provide the following information by filling in [the template][issue-template].

Explain the problem and include additional details to help maintainers reproduce the problem:

* **Use a clear and descriptive title** for the issue to identify the problem.
* **Describe the exact steps which reproduce the problem** in as many details as possible. When listing steps, **don't just say what you did, but explain how you did it**. For example, if you moved the cursor to the end of a line, explain if you used the mouse, or a keyboard shortcut, and if so which one?
* **Provide specific examples to demonstrate the steps**. Include links to files or GitHub projects, or copy/pasteable snippets, which you use in those examples. If you're providing snippets in the issue, use [Markdown code blocks](https://help.github.com/articles/markdown-basics/#multiple-lines).
* **Describe the behavior you observed after following the steps** and point out what exactly is the problem with that behavior.
* **Explain which behavior you expected to see instead and why.**
* **Include screenshots and animated GIFs** which show you following the described steps and clearly demonstrate the problem.  You can use [this tool](https://www.cockos.com/licecap/) to record GIFs on macOS and Windows, and [this tool](https://github.com/colinkeenan/silentcast) or [this tool](https://github.com/GNOME/byzanz) on Linux.


Provide more context by answering these questions:


* **Did the problem start happening recently** (e.g. after updating to a new version of JumpList) or was this always a problem?
* **Can you reliably reproduce the issue?** If not, provide details about how often the problem happens and under which conditions it normally happens.
* If the problem is related to working with files (e.g. opening and editing files), **does the problem happen for all files and projects or only some?** Does the problem happen only when working with local or remote files (e.g. on network drives), with files of a specific type (e.g. only JavaScript or Python files), with large files or files with very long lines, or with files in a specific encoding? Is there anything else special about the files you are using?

Include details about your configuration and environment:

* **What's the name and version of the OS you're using?**
* **What browser are you using?** Are you using Chrome, Firefox, what versions?
* **Which keyboard layout are you using?** Are you using a US layout or some other layout?

<div id='se'/>

### Suggesting Enhancements

This section guides you through submitting an enhancement suggestion for JumpList, including completely new features and minor improvements to existing functionality. Following these guidelines helps maintainers and the community understand your suggestion :pencil: and find related suggestions :mag_right:.

Before creating enhancement suggestions, Perform a [cursory search][search-enhancement] to see if the enhancement has already been suggested. If it has, add a comment to the existing issue instead of opening a new one. When you are creating an enhancement suggestion, please include as many details as possible. Fill in [the template][issue-template], including the steps that you imagine you would take if the feature you're requesting existed.

<div id='yfcc'/>

### Your First Code Contribution

Unsure where to begin contributing to JumpList? You can start by looking through these `good first issue`, `beginner` and `help-wanted` issues:

* [Good First Issue issues][good-first-issue] - issues which should be save for those who are just getting into the open-source community, or have yet to assist in the project.
* [Beginner issues][beginner] - issues which should only require a few lines of code, and a test or two.
* [Help Wanted issues][help-wanted] - issues which should be a bit more involved than `beginner` issues.

Both issue lists are sorted by total number of comments. While not perfect, number of comments is a reasonable proxy for impact a given change will have.

<div id='pr'/>

### Pull Requests

* Fill in [the required template][pull-template]
* Do not include issue numbers in the PR title
* Include screenshots and animated GIFs in your pull request whenever possible.
* Follow the styleguides.
* Document new code comments.
* End all files with a newline.

<div id='sg'/>

## Styleguides

<div id='gcm'/>

### Git Commit Messages

* Use the present tense ("Add feature" not "Added feature")
* Use the imperative mood ("Move cursor to..." not "Moves cursor to...")
* Limit the first line to 72 characters or less
* Reference issues and pull requests liberally after the first line
* When only changing documentation, include `[ci skip]` in the commit title
* Consider starting the commit message with an applicable emoji:
    * :art: `:art:` when improving the format/structure of the code
    * :racehorse: `:racehorse:` when improving performance
    * :non-potable_water: `:non-potable_water:` when plugging memory leaks
    * :memo: `:memo:` when writing docs
    * :penguin: `:penguin:` when fixing something on Linux
    * :apple: `:apple:` when fixing something on macOS
    * :checkered_flag: `:checkered_flag:` when fixing something on Windows
    * :bug: `:bug:` when fixing a bug
    * :fire: `:fire:` when removing code or files
    * :green_heart: `:green_heart:` when fixing the CI build
    * :white_check_mark: `:white_check_mark:` when adding tests
    * :lock: `:lock:` when dealing with security
    * :arrow_up: `:arrow_up:` when upgrading dependencies
    * :arrow_down: `:arrow_down:` when downgrading dependencies
    * :shirt: `:shirt:` when removing linter warnings

<div id='more'/>

### Styleguides++

All JavaScript must adhere to [JavaScript Standard Style][JSS].  
Use [Markdown][MarkdownLink] for documentation.

<div id='an'/>

## Additional Notes

<div id='iprl'/>

### Issue and Pull Request Labels

This section lists the labels we use to help us track and manage issues and pull requests. Most labels are used across all repositories, but some are specific to JumpList.

[GitHub search](https://help.github.com/articles/searching-issues/) makes it easy to use labels for finding groups of issues or pull requests you're interested in. For example, you might be interested in [open issues]() across JumpList  which are labeled as bugs, but still need to be reliably reproduced or perhaps [open pull requests]() in JumpList which haven't been reviewed yet. To help you find issues and pull requests, each label is listed with search links for finding open items with that label. We encourage you to read about [other search filters](https://help.github.com/articles/searching-issues/) which will help you write more focused queries.

The labels are loosely grouped by their purpose, but it's not required that every issue have a label from every group or that an issue can't have more than one label from the same group.

<div id='tiis'/>

#### Type of Issue and Issue State

| Label name | Description |
| --- | --- |
| `enhancement` | Feature requests. |
| `bug` | Confirmed bugs or reports that are very likely to be bugs. |
| `question` | Questions more than bug reports or feature requests (e.g. how do I do X). |
| `feedback` | General feedback more than bug reports or feature requests. |
| `help-wanted` | The  team would appreciate help from the community in resolving these issues. |
| `beginner` | Less complex issues which would be good first issues to work on for users who want to contribute. |
| `more-information-needed` | More information needs to be collected about these problems or feature requests (e.g. steps to reproduce). |
| `needs-reproduction` | Likely bugs, but haven't been reliably reproduced. |
| `blocked` | Issues blocked on other issues. |
| `duplicate` | Issues which are duplicates of other issues, i.e. they have been reported before. |
| `wontfix` | The team has decided not to fix these issues for now, either because they're working as intended or for some other reason. |
| `invalid` | Issues which aren't valid (e.g. user errors). |

<div id='prl'/>

#### Pull Request Labels

| Label name | Description
| --- | --- |
| `work-in-progress` | Pull requests which are still being worked on, more changes will follow. |
| `needs-review` | Pull requests which need code review, and approval from maintainers or team. |
| `under-review` | Pull requests being reviewed by maintainers or team. |
| `requires-changes` | Pull requests which need to be updated based on review comments and then reviewed again. |
| `needs-testing` | Pull requests which need manual testing. |

<div id='a4h'/>

## Asking for help

We appreciate your effort in taking the time to work on this issue and help out the open source community.
If you need any help, feel free to ask below. We are always happy to help 😄

[profile]:https://github.com/aaronmaynard
[CoC]:CODE_OF_CONDUCT.md
[discord]:https://discord.gg/GhUnXeY
[issue-template]:ISSUE_TEMPLATE.md
[search-enhancement]:https://github.com/aaronmaynard/JumpList/search?q=is%3Aissue+is%3Aopen+label%3A%22enhancement%22+&type=Issues&utf8=%E2%9C%93
[beginner]:https://github.com/aaronmaynard/JumpList/search?q=is%3Aissue+is%3Aopen+label%3A%22beginner%22+&type=Issues&utf8=%E2%9C%93
[good-first-issue]:https://github.com/aaronmaynard/JumpList/search?q=is%3Aissue+is%3Aopen+label%3A%22good+first+issue%22+&type=Issues&utf8=%E2%9C%93
[help-wanted]:https://github.com/aaronmaynard/JumpList/search?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22+&type=Issues&utf8=%E2%9C%93
[pull-template]:PULL_REQUEST_TEMPLATE.md
[JSS]:https://standardjs.com/
[MarkdownLink]:https://daringfireball.net/projects/markdown
